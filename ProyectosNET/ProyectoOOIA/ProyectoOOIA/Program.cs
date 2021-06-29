using ProyectoOOIA.Ventanas;
using System;
using System.Windows.Forms;

namespace ProyectoOOIA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmInicioSesion pantalla = new frmInicioSesion();

            pantalla.FormClosed += MainForm_Closed;
            pantalla.Show();

            //Application.Run(new frmPrincipalAlumno());
            Application.Run();
        }
        private static void MainForm_Closed(Object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
        //private void zoom()
        //{
        //    var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
        //    var now = DateTime.UtcNow;
        //    var apiSecret = "40BLxSs4nUvOoKRUHYqENitX54CZcM1CNJh2";
        //    byte[] symmetricKey = Encoding.ASCII.GetBytes(apiSecret);

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Issuer = "AC5lcAH8TSauiI2_3jS1JQ",
        //        Expires = now.AddSeconds(300),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256),
        //    };
        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    var tokenString = tokenHandler.WriteToken(token);
        //    var client = new RestClient("https://api.zoom.us/v2/users/ooia.no.reply@gmail.com/meetings");
        //    var request = new RestRequest(Method.POST);
        //    request.RequestFormat = DataFormat.Json;
        //    request.AddJsonBody(new { topic = "Meeting with Alvaro", duration = "30", start_time = "2021-06-26T18:10:00", type = "2" });
        //    //, schedule_for = "alvaro.calderon@pucp.edu.pe"
        //    request.AddHeader("authorization", String.Format("Bearer {0}", tokenString));

        //    IRestResponse restResponse = client.Execute(request);
        //    HttpStatusCode statusCode = restResponse.StatusCode;
        //    int numericStatusCode = (int)statusCode;
        //    var jObject = JObject.Parse(restResponse.Content);
        //    txtHost.Text += (string)jObject["start_url"];
        //    txtjoin.Text += (string)jObject["join_url"];
        //    lbl3.Text += Convert.ToString(numericStatusCode);
        //}
    }
}
