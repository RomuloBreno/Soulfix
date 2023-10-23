using System.ComponentModel.DataAnnotations;

namespace Soulfix.Models
{
    public class LoginModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o login")]
        public string? Login { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string? Pswrd { get; set; }
        public int Type { get; set; }
        public int? UserId { get; set; }


        public string ValidType(int type)
		{
			
			switch (type)
			{
				//Admin
				case 1:
					return "Admin";
                //Coordenador
                case 2:
                    return "UserMaster";
                //Professor
                case 3:
                    return "User";
                //Client
                case 4:
                    return "Client";
                default:
					break;
			}

			return "Client";

        }



	}
}