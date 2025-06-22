using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DataAccessesLayerApi;
using static DataAccessesLayerApi.clsPrudctionData;
using static DataAccessesLayerApi.clsRaawMatirailsData;
using static DataAccessesLayerApi.clsUserData;

namespace BussinesLayerApi
{
    public class clsUser
    {
        public UserDTO UDTO
        {
            get
            {
                return (new UserDTO(this.Name));
            }
        }

        public string? Name { get; set; }


        public clsUser(UserDTO uDTO)
        {
            this.Name = uDTO.Name;

        }

        public static List<UserDTO> GetAllRows(string UserName, string Passowrd)
        {
            Passowrd = _ComputeHash(Passowrd);
            return clsUserData.GetAllRows(UserName, Passowrd);
        }
        private static string _ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
