using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat
{
    class Student
    {
        public static List<Info> Students()
        {
            var students = new List<Info>
            {
                new Info{ 
                Name="Ayxan",
                Surname="Axundov",
                LogInDate="3.17.2021",
                Brithday=new DateTime(2001,06,06),
                FatherName="Aqil"
                },
                new Info{ 
                Name="Shemseddin",
                Surname="Axundov",
                FatherName="Aqil",
                Brithday=new DateTime(2002,06,13),
                LogInDate="2,13,2021"
                },
                 new Info{ 
                Name="Emin",
                Surname="Quluzade",
                FatherName="Ilqar",
                Brithday=new DateTime(2001,07,11),
                LogInDate="2,13,2018"
                },
                new Info{ 
                Name="Zaur",
                Surname="Ceferov",
                FatherName="Ceyhun",
                Brithday=new DateTime(2001,06,12),
                LogInDate="2,13,2000 - Azig adami..."
                },
                new Info{ 
                Name="Arifeli",
                Surname="Bagirli",
                FatherName="Father",
                Brithday=new DateTime(2018,04,28),
                LogInDate="03,11,11"
                }
            };
            return students;
        }
    }
}
