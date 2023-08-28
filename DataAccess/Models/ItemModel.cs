using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;
public class ItemModel
{
    public int ItemID { get; set; }
    public int CategoryID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

