using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp;
#pragma warning disable
[Table("Contacts")]
public class Contact
{
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; } //primary key

    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public override string ToString()
    {
        return String.Format("{0,-10} {1,-10} {2,-25} {3,-10} {4,-9}", Name,"-",Email,"-",PhoneNumber);
    }
}
