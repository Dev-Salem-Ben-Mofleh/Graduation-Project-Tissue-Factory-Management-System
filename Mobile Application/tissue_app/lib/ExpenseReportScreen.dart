import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class ExpenseReportScreen extends StatefulWidget {
  @override
  _ExpenseReportScreenState createState() => _ExpenseReportScreenState();
}

class _ExpenseReportScreenState extends State<ExpenseReportScreen> {
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
            'https://tissue.runasp.net/api/Tissue/GetExpenseReport/$date'),
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

  Widget _buildInfoCard(
      String title, String value, IconData icon, Color color) {
    return Container(
      margin: EdgeInsets.symmetric(vertical: 8),
      child: Card(
        elevation: 4,
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(15),
        ),
        child: Container(
          padding: EdgeInsets.all(16),
          decoration: BoxDecoration(
            gradient: LinearGradient(
              begin: Alignment.topLeft,
              end: Alignment.bottomRight,
              colors: [
                color.withOpacity(0.1),
                color.withOpacity(0.05),
              ],
            ),
            borderRadius: BorderRadius.circular(15),
          ),
          child: Row(
            children: [
              Container(
                padding: EdgeInsets.all(12),
                decoration: BoxDecoration(
                  color: color.withOpacity(0.1),
                  borderRadius: BorderRadius.circular(12),
                ),
                child: Icon(icon, color: color, size: 24),
              ),
              SizedBox(width: 16),
              Expanded(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      title,
                      style: TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.bold,
                        color: Colors.grey[800],
                      ),
                    ),
                    SizedBox(height: 4),
                    Text(
                      value,
                      style: TextStyle(
                        fontSize: 18,
                        color: color,
                        fontWeight: FontWeight.w600,
                      ),
                    ),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0xFFF3F6F9),
      appBar: AppBar(
        title: Text('💸 تقارير المصروفات'),
        centerTitle: true,
        backgroundColor: Colors.indigo,
        elevation: 0,
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.vertical(
            bottom: Radius.circular(20),
          ),
        ),
      ),
      body: SingleChildScrollView(
        padding: const EdgeInsets.all(20),
        child: Column(
          children: [
            Container(
              decoration: BoxDecoration(
                color: Colors.white,
                borderRadius: BorderRadius.circular(15),
                boxShadow: [
                  BoxShadow(
                    color: Colors.grey.withOpacity(0.1),
                    spreadRadius: 1,
                    blurRadius: 10,
                    offset: Offset(0, 3),
                  ),
                ],
              ),
              child: TextFormField(
                controller: _dateController,
                decoration: InputDecoration(
                  labelText: 'اختر التاريخ',
                  filled: true,
                  fillColor: Colors.white,
                  prefixIcon: Icon(Icons.date_range, color: Colors.indigo),
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(15),
                    borderSide: BorderSide.none,
                  ),
                  enabledBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(15),
                    borderSide: BorderSide.none,
                  ),
                  focusedBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(15),
                    borderSide: BorderSide(color: Colors.indigo, width: 2),
                  ),
                ),
                readOnly: true,
                onTap: () => _selectDate(context),
              ),
            ),
            SizedBox(height: 24),
            _isLoading
                ? Center(
                    child: CircularProgressIndicator(
                      valueColor: AlwaysStoppedAnimation<Color>(Colors.indigo),
                    ),
                  )
                : _reportData == null || _reportData!.isEmpty
                    ? Container(
                        height: MediaQuery.of(context).size.height * 0.7,
                        child: Center(
                          child: Column(
                            mainAxisAlignment: MainAxisAlignment.center,
                            children: [
                              Icon(
                                Icons.info_outline,
                                size: 48,
                                color: Colors.grey[400],
                              ),
                              SizedBox(height: 16),
                              Text(
                                _errorMessage.isEmpty
                                    ? 'اختر تاريخًا لعرض التقرير'
                                    : _errorMessage,
                                style: TextStyle(
                                  fontSize: 18,
                                  color: Colors.grey[600],
                                  fontWeight: FontWeight.bold,
                                ),
                                textAlign: TextAlign.center,
                              ),
                            ],
                          ),
                        ),
                      )
                    : Column(
                        children: [
                          _buildInfoCard(
                            '📅 التاريخ',
                            _reportData![0]['expenseDate']
                                .toString()
                                .split('T')[0],
                            Icons.calendar_today,
                            Colors.blue,
                          ),
                          _buildInfoCard(
                            '💰 الإجمالي',
                            '${_reportData![0]['total']} ريال',
                            Icons.attach_money,
                            Colors.green,
                          ),
                          _buildInfoCard(
                            '🧾 عدد الفواتير',
                            _reportData![0]['countBills'].toString(),
                            Icons.receipt,
                            Colors.orange,
                          ),
                          _buildInfoCard(
                            '📌 نوع المصروف',
                            _reportData![0]['name'],
                            Icons.category,
                            Colors.purple,
                          ),
                          _buildInfoCard(
                            '💳 المبلغ المدفوع',
                            '${_reportData![0]['amount']} ريال',
                            Icons.payment,
                            Colors.teal,
                          ),
                        ],
                      ),
          ],
        ),
      ),
    );
  }
}
