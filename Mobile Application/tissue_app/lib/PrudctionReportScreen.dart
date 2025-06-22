import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class ProductionReportScreen extends StatefulWidget {
  @override
  _ProductionReportScreenState createState() => _ProductionReportScreenState();
}

class _ProductionReportScreenState extends State<ProductionReportScreen> {
  final _dateController = TextEditingController();
  List<dynamic>? _reportData;
  bool _isLoading = false;
  String _errorMessage = '';

  @override
  void initState() {
    super.initState();
    final today = DateTime.now();
    final formattedToday = "${today.toLocal()}".split(' ')[0];
    _dateController.text = formattedToday;
    _fetchReport(formattedToday);
  }

  Future<void> _fetchReport(String date) async {
    setState(() {
      _isLoading = true;
      _errorMessage = '';
    });

    try {
      final response = await http.get(
        Uri.parse(
            'https://tissue.runasp.net/api/Tissue/GetPrudctionReport/$date'),
        headers: {'Content-Type': 'application/json; charset=UTF-8'},
      );

      if (response.statusCode == 200) {
        final data = json.decode(response.body);
        if (data != null && data.isNotEmpty) {
          setState(() {
            _reportData = data;
          });
        } else {
          setState(() {
            _reportData = null;
            _errorMessage = 'لا يوجد تقرير لهذا اليوم';
          });
        }
      } else {
        setState(() {
          _reportData = null;
          _errorMessage = 'حدث خطأ أثناء جلب البيانات';
        });
      }
    } catch (e) {
      setState(() {
        _reportData = null;
        _errorMessage = 'حدث خطأ: $e';
      });
    } finally {
      setState(() {
        _isLoading = false;
      });
    }
  }

  Future<void> _selectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: DateTime.now(),
      firstDate: DateTime(2000),
      lastDate: DateTime(2101),
    );
    if (picked != null) {
      final formatted = "${picked.toLocal()}".split(' ')[0];
      setState(() {
        _dateController.text = formatted;
      });
      _fetchReport(formatted);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('🏭 تقارير الإنتاج'),
        centerTitle: true,
        backgroundColor: Colors.indigo,
      ),
      body: SingleChildScrollView(
        padding: const EdgeInsets.all(20),
        child: Column(
          children: [
            TextFormField(
              controller: _dateController,
              decoration: InputDecoration(
                labelText: 'اختر التاريخ',
                filled: true,
                fillColor: Colors.grey[100],
                prefixIcon: Icon(Icons.date_range, color: Colors.indigo),
                border: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(12),
                ),
              ),
              readOnly: true,
              onTap: () => _selectDate(context),
            ),
            SizedBox(height: 20),
            _isLoading
                ? Center(child: CircularProgressIndicator())
                : _reportData == null || _reportData!.isEmpty
                    ? Container(
                        height: MediaQuery.of(context).size.height * 0.7,
                        child: Center(
                          child: Text(
                            _errorMessage.isEmpty
                                ? 'اختر تاريخًا لعرض التقرير'
                                : _errorMessage,
                            style: TextStyle(
                                fontSize: 18,
                                color: Colors.red,
                                fontWeight: FontWeight.bold),
                          ),
                        ),
                      )
                    : Column(
                        children: [
                          _buildInfoCard(
                              '📅 التاريخ',
                              _reportData![0]['productionDate']
                                  .toString()
                                  .split('T')[0]),
                          _buildInfoCard(
                              '📦 اسم المنتج', _reportData![0]['productName']),
                          _buildInfoCard('🔄 الكمية المنتجة',
                              '${_reportData![0]['quantity']} وحدة'),
                          _buildInfoCard('⚠️ الكمية التالفة',
                              '${_reportData![0]['damagedQuantity']} وحدة'),
                          _buildInfoCard('🧾 اسم المادة المستهلكة',
                              _reportData![0]['material_Name']),
                          _buildInfoCard('⚖️ الكمية المستهلكة',
                              '${_reportData![0]['rawAmount']} كجم'),
                        ],
                      ),
          ],
        ),
      ),
    );
  }

  Widget _buildInfoCard(String title, String value) {
    return Card(
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(15)),
      elevation: 4,
      margin: EdgeInsets.symmetric(vertical: 10),
      child: ListTile(
        leading: Icon(Icons.arrow_forward_ios, color: Colors.indigo),
        title: Text(title, style: TextStyle(fontWeight: FontWeight.bold)),
        subtitle: Text(value, style: TextStyle(fontSize: 16)),
      ),
    );
  }
}
