using System;
using System.Collections.Generic;
using System.Text;
using SystemeVentes.Models;

namespace SystemeVentes.Services
{
    public class ProductDataService : IDataService<Product>
    {
        private static List<Product> produits;

        public ProductDataService()
        {   
            initData();
        }

        private void initData()
        {
            /// Si les données sont déjà initialisées, ne pas la refaire
            if (produits != null) return;

            produits = new List<Product>
            {
                new Product() { UPC = "523438", Code = "TUE354", Name = "cubilia Curae; Donec tincidunt.", Description = "pede, nonummy ut, molestie in, tempus eu, ligula. Aenean", SalePrice = 10.45M },
                new Product() { UPC = "536976", Code = "CWQ999", Name = "enim. Nunc", Description = "malesuada malesuada. Integer id magna et ipsum cursus vestibulum. Mauris", SalePrice = 0.8M },
                new Product() { UPC = "762723", Code = "XVA415", Name = "nisi a", Description = "cursus et, magna. Praesent interdum ligula eu enim. Etiam", SalePrice = 5.92M },
                new Product() { UPC = "146509", Code = "YWC365", Name = "Quisque ornare tortor", Description = "vel, venenatis vel, faucibus id, libero. Donec consectetuer mauris", SalePrice = 13.9M },
                new Product() { UPC = "911706", Code = "LSF234", Name = "luctus vulputate, nisi", Description = "et ultrices posuere cubilia Curae;", SalePrice = 14.81M },
                new Product() { UPC = "228914", Code = "NDN489", Name = "sociis natoque", Description = "diam at pretium aliquet, metus urna convallis", SalePrice = 6.91M },
                new Product() { UPC = "345007", Code = "GBZ176", Name = "in felis. Nulla", Description = "ac risus. Morbi metus. Vivamus euismod urna.", SalePrice = 15.68M },
                new Product() { UPC = "707756", Code = "FAW714", Name = "in faucibus orci luctus", Description = "hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim.", SalePrice = 14.21M },
                new Product() { UPC = "834773", Code = "VMM742", Name = "et magnis dis", Description = "urna. Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis", SalePrice = 0.54M },
                new Product() { UPC = "754822", Code = "JZG819", Name = "elit, pretium et,", Description = "Integer tincidunt aliquam arcu. Aliquam ultrices iaculis odio. Nam", SalePrice = 6.14M },
                new Product() { UPC = "943275", Code = "KBJ597", Name = "aliquet, sem", Description = "adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut", SalePrice = 1.89M },
                new Product() { UPC = "322576", Code = "DZT371", Name = "ornare. In", Description = "Phasellus in felis. Nulla tempor augue ac", SalePrice = 6.27M },
                new Product() { UPC = "119448", Code = "XJM693", Name = "Vivamus euismod", Description = "pretium aliquet, metus urna convallis erat, eget tincidunt", SalePrice = 13.19M },
                new Product() { UPC = "730891", Code = "MMY364", Name = "sapien. Cras dolor", Description = "vestibulum. Mauris magna. Duis dignissim tempor arcu. Vestibulum ut eros", SalePrice = 14.1M },
                new Product() { UPC = "259402", Code = "ACA897", Name = "mollis nec, cursus a,", Description = "eleifend, nunc risus varius orci, in consequat enim diam vel", SalePrice = 1.06M },
                new Product() { UPC = "303251", Code = "PFF636", Name = "Sed malesuada augue ut", Description = "aliquet vel, vulputate eu, odio.", SalePrice = 9.78M },
                new Product() { UPC = "492491", Code = "CYV351", Name = "Nam ac nulla. In", Description = "ultrices posuere cubilia Curae;", SalePrice = 7.09M },
                new Product() { UPC = "951243", Code = "UBY236", Name = "Curabitur dictum. Phasellus", Description = "eget, dictum placerat, augue. Sed molestie. Sed id risus", SalePrice = 3.92M },
                new Product() { UPC = "320726", Code = "BCV239", Name = "lacinia vitae, sodales at,", Description = "tempor lorem, eget mollis lectus pede", SalePrice = 15.56M },
                new Product() { UPC = "144441", Code = "RCI621", Name = "lacus. Cras interdum.", Description = "Sed id risus quis diam luctus lobortis. Class aptent", SalePrice = 3.54M },
                new Product() { UPC = "730982", Code = "IOI451", Name = "semper, dui lectus", Description = "vel lectus. Cum sociis natoque", SalePrice = 17.69M },
                new Product() { UPC = "189671", Code = "OMM777", Name = "et ipsum cursus vestibulum.", Description = "quam quis diam. Pellentesque habitant morbi tristique", SalePrice = 4.86M },
                new Product() { UPC = "423148", Code = "DSY688", Name = "tempor lorem,", Description = "in lobortis tellus justo sit amet nulla. Donec non justo.", SalePrice = 8.21M },
                new Product() { UPC = "593819", Code = "TOO234", Name = "dignissim lacus.", Description = "montes, nascetur ridiculus mus. Proin", SalePrice = 10.16M },
                new Product() { UPC = "676350", Code = "JLK988", Name = "urna justo", Description = "sociosqu ad litora torquent per conubia nostra,", SalePrice = 11.39M },
                new Product() { UPC = "614105", Code = "WSF638", Name = "lacus. Etiam bibendum fermentum", Description = "magna. Ut tincidunt orci", SalePrice = 14.43M },
                new Product() { UPC = "933192", Code = "SKX599", Name = "Quisque libero lacus,", Description = "laoreet, libero et tristique pellentesque, tellus sem mollis", SalePrice = 15.73M },
                new Product() { UPC = "365557", Code = "FNF818", Name = "faucibus lectus,", Description = "lobortis ultrices. Vivamus rhoncus. Donec est. Nunc ullamcorper, velit in", SalePrice = 18.26M },
                new Product() { UPC = "297026", Code = "SGX461", Name = "dolor quam, elementum", Description = "In ornare sagittis felis. Donec", SalePrice = 11.77M },
                new Product() { UPC = "429457", Code = "VEP669", Name = "nec, euismod in, dolor.", Description = "non, vestibulum nec, euismod in, dolor. Fusce", SalePrice = 8.86M },
                new Product() { UPC = "960083", Code = "PPR756", Name = "tincidunt dui augue", Description = "id nunc interdum feugiat. Sed nec metus facilisis", SalePrice = 14.58M },
                new Product() { UPC = "212740", Code = "NNE521", Name = "et risus. Quisque", Description = "faucibus id, libero. Donec", SalePrice = 6.34M },
                new Product() { UPC = "271197", Code = "HHW964", Name = "velit. Cras lorem lorem,", Description = "sociis natoque penatibus et magnis dis parturient montes, nascetur", SalePrice = 13.27M },
                new Product() { UPC = "666742", Code = "OEZ681", Name = "sociis natoque penatibus et", Description = "facilisis facilisis, magna tellus faucibus leo, in", SalePrice = 13.7M },
                new Product() { UPC = "556285", Code = "RMG458", Name = "blandit congue.", Description = "turpis vitae purus gravida sagittis. Duis gravida. Praesent", SalePrice = 0.84M },
                new Product() { UPC = "788430", Code = "NKL512", Name = "blandit enim consequat", Description = "pretium et, rutrum non, hendrerit id, ante. Nunc mauris sapien,", SalePrice = 16.72M },
                new Product() { UPC = "533207", Code = "PTD893", Name = "faucibus orci luctus et", Description = "convallis est, vitae sodales nisi magna sed dui.", SalePrice = 3.23M },
                new Product() { UPC = "527368", Code = "XAL773", Name = "orci, adipiscing non, luctus", Description = "vitae sodales nisi magna sed dui. Fusce aliquam,", SalePrice = 0.85M },
                new Product() { UPC = "813413", Code = "TTK131", Name = "lorem. Donec elementum,", Description = "ullamcorper, nisl arcu iaculis", SalePrice = 19.89M },
                new Product() { UPC = "465468", Code = "YDH783", Name = "metus. Aenean sed", Description = "magna. Phasellus dolor elit, pellentesque a, facilisis non, bibendum sed,", SalePrice = 11.99M },
                new Product() { UPC = "949748", Code = "YWW591", Name = "quis accumsan", Description = "ligula. Nullam feugiat placerat", SalePrice = 7.16M },
                new Product() { UPC = "906302", Code = "BBN941", Name = "Sed dictum. Proin", Description = "Vestibulum accumsan neque et nunc. Quisque", SalePrice = 3.75M },
                new Product() { UPC = "964056", Code = "GQU772", Name = "egestas. Fusce aliquet magna", Description = "Aenean eget magna. Suspendisse tristique neque venenatis lacus. Etiam bibendum", SalePrice = 7.2M },
                new Product() { UPC = "966599", Code = "HJO237", Name = "Ut sagittis", Description = "convallis ligula. Donec luctus aliquet odio.", SalePrice = 18.83M },
                new Product() { UPC = "103053", Code = "YYS417", Name = "diam at pretium", Description = "Mauris blandit enim consequat purus. Maecenas libero est, congue a,", SalePrice = 10.07M },
                new Product() { UPC = "509399", Code = "CEH256", Name = "tellus. Phasellus elit pede,", Description = "Fusce mi lorem, vehicula et, rutrum", SalePrice = 17.26M },
                new Product() { UPC = "662406", Code = "SVK239", Name = "placerat, orci lacus", Description = "parturient montes, nascetur ridiculus mus. Proin vel", SalePrice = 5.05M },
                new Product() { UPC = "693337", Code = "DLC216", Name = "dictum placerat, augue. Sed", Description = "malesuada fringilla est. Mauris eu turpis.", SalePrice = 1.21M },
                new Product() { UPC = "205003", Code = "ZDF178", Name = "ornare egestas ligula.", Description = "in consequat enim diam vel arcu. Curabitur ut", SalePrice = 5.67M },
                new Product() { UPC = "504490", Code = "ZQM286", Name = "lobortis. Class aptent", Description = "adipiscing ligula. Aenean gravida nunc sed pede.", SalePrice = 0.1M },
                new Product() { UPC = "962953", Code = "BOR339", Name = "malesuada vel,", Description = "pede ac urna. Ut tincidunt vehicula risus. Nulla eget metus", SalePrice = 4.88M },
                new Product() { UPC = "578585", Code = "FZD797", Name = "dui quis accumsan convallis,", Description = "libero. Proin mi. Aliquam gravida mauris", SalePrice = 12.06M },
                new Product() { UPC = "506506", Code = "YCF835", Name = "at fringilla", Description = "diam. Pellentesque habitant morbi tristique senectus et netus", SalePrice = 16.2M },
                new Product() { UPC = "726518", Code = "IXT315", Name = "ipsum porta elit,", Description = "elit. Nulla facilisi. Sed", SalePrice = 17.3M },
                new Product() { UPC = "415477", Code = "XMQ582", Name = "Phasellus libero", Description = "luctus ut, pellentesque eget, dictum placerat, augue.", SalePrice = 8.84M },
                new Product() { UPC = "587108", Code = "UDN329", Name = "et magnis dis", Description = "Proin vel arcu eu odio tristique pharetra. Quisque ac", SalePrice = 9.23M },
                new Product() { UPC = "354517", Code = "SSU516", Name = "molestie pharetra nibh.", Description = "enim. Etiam gravida molestie arcu. Sed eu nibh", SalePrice = 12.67M },
                new Product() { UPC = "375659", Code = "WFA482", Name = "velit justo", Description = "venenatis vel, faucibus id,", SalePrice = 2.29M },
                new Product() { UPC = "793417", Code = "BAU181", Name = "Proin vel", Description = "egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede.", SalePrice = 3.5M },
                new Product() { UPC = "971100", Code = "VBX277", Name = "Ut tincidunt vehicula risus.", Description = "adipiscing. Mauris molestie pharetra nibh. Aliquam ornare,", SalePrice = 19.05M },
                new Product() { UPC = "181731", Code = "WUZ769", Name = "Praesent eu nulla", Description = "vulputate, nisi sem semper erat, in consectetuer ipsum", SalePrice = 12.02M },
                new Product() { UPC = "599878", Code = "JKE847", Name = "condimentum. Donec at arcu.", Description = "vehicula aliquet libero. Integer in magna. Phasellus", SalePrice = 13.04M },
                new Product() { UPC = "497968", Code = "ANH395", Name = "elementum purus,", Description = "ac risus. Morbi metus. Vivamus euismod urna.", SalePrice = 17.18M },
                new Product() { UPC = "554777", Code = "BML235", Name = "Phasellus elit", Description = "iaculis nec, eleifend non, dapibus", SalePrice = 13.2M },
                new Product() { UPC = "617338", Code = "IDO345", Name = "at lacus. Quisque purus", Description = "a odio semper cursus. Integer mollis. Integer tincidunt aliquam", SalePrice = 18.14M },
                new Product() { UPC = "935834", Code = "UNI116", Name = "nisi. Cum sociis", Description = "Phasellus in felis. Nulla tempor augue ac ipsum. Phasellus", SalePrice = 14.81M },
                new Product() { UPC = "561866", Code = "RKE564", Name = "Quisque porttitor", Description = "scelerisque neque sed sem egestas", SalePrice = 12.31M },
                new Product() { UPC = "989383", Code = "AQS814", Name = "Nulla tempor augue", Description = "Phasellus dapibus quam quis diam. Pellentesque habitant morbi", SalePrice = 6.98M },
                new Product() { UPC = "220848", Code = "QFO194", Name = "imperdiet, erat", Description = "arcu iaculis enim, sit", SalePrice = 9.68M },
                new Product() { UPC = "763853", Code = "PEK412", Name = "diam at pretium", Description = "mauris ipsum porta elit, a feugiat", SalePrice = 9.11M },
                new Product() { UPC = "207497", Code = "ANA654", Name = "luctus lobortis. Class aptent", Description = "dolor. Nulla semper tellus id nunc", SalePrice = 13.32M },
                new Product() { UPC = "585484", Code = "DAT732", Name = "enim commodo hendrerit. Donec", Description = "mauris blandit mattis. Cras eget nisi dictum augue", SalePrice = 4.18M },
                new Product() { UPC = "660482", Code = "ZCN454", Name = "arcu. Vestibulum ante", Description = "ante. Vivamus non lorem vitae", SalePrice = 4.36M },
                new Product() { UPC = "741368", Code = "MVB595", Name = "a, enim. Suspendisse", Description = "pede, malesuada vel, venenatis vel, faucibus id, libero. Donec", SalePrice = 8.78M },
                new Product() { UPC = "608315", Code = "JTD349", Name = "Praesent interdum ligula eu", Description = "et tristique pellentesque, tellus", SalePrice = 0.88M },
                new Product() { UPC = "183967", Code = "YWQ564", Name = "lectus rutrum", Description = "rutrum magna. Cras convallis convallis dolor.", SalePrice = 1M },
                new Product() { UPC = "198995", Code = "XQQ312", Name = "Nulla eu", Description = "luctus sit amet, faucibus ut, nulla.", SalePrice = 11.33M },
                new Product() { UPC = "218551", Code = "YGE572", Name = "massa. Mauris", Description = "odio. Phasellus at augue", SalePrice = 16.04M },
                new Product() { UPC = "129076", Code = "WOF679", Name = "Nulla interdum.", Description = "porttitor eros nec tellus. Nunc lectus pede,", SalePrice = 19.8M },
                new Product() { UPC = "576793", Code = "ALK921", Name = "ullamcorper viverra. Maecenas", Description = "quis lectus. Nullam suscipit, est ac facilisis facilisis, magna tellus", SalePrice = 5.86M },
                new Product() { UPC = "279189", Code = "HVU571", Name = "sagittis felis.", Description = "ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi", SalePrice = 18.7M },
                new Product() { UPC = "868803", Code = "LZZ424", Name = "libero lacus,", Description = "tellus lorem eu metus.", SalePrice = 13.35M },
                new Product() { UPC = "360716", Code = "NEI885", Name = "congue. In scelerisque", Description = "tortor, dictum eu, placerat", SalePrice = 9.58M },
                new Product() { UPC = "856699", Code = "CKN615", Name = "pharetra. Quisque ac", Description = "ipsum cursus vestibulum. Mauris magna.", SalePrice = 9.59M },
                new Product() { UPC = "487392", Code = "CJF615", Name = "sit amet", Description = "dapibus ligula. Aliquam erat volutpat. Nulla dignissim. Maecenas ornare", SalePrice = 12.45M },
                new Product() { UPC = "390804", Code = "DJB164", Name = "hendrerit consectetuer, cursus et,", Description = "tristique senectus et netus", SalePrice = 17.9M },
                new Product() { UPC = "797985", Code = "GIV434", Name = "tincidunt adipiscing.", Description = "eget, ipsum. Donec sollicitudin adipiscing ligula.", SalePrice = 11.16M },
                new Product() { UPC = "561585", Code = "LKA356", Name = "mi fringilla mi lacinia", Description = "non quam. Pellentesque habitant", SalePrice = 6.14M },
                new Product() { UPC = "894857", Code = "XUQ412", Name = "ac mi eleifend", Description = "euismod ac, fermentum vel, mauris. Integer sem elit, pharetra ut,", SalePrice = 8.39M },
                new Product() { UPC = "412060", Code = "IBK593", Name = "sodales. Mauris blandit enim", Description = "lorem fringilla ornare placerat, orci lacus vestibulum", SalePrice = 5.72M },
                new Product() { UPC = "304847", Code = "WMM427", Name = "ipsum nunc id", Description = "luctus aliquet odio. Etiam ligula tortor, dictum eu,", SalePrice = 1.25M },
                new Product() { UPC = "895822", Code = "GBV677", Name = "ridiculus mus. Proin vel", Description = "ridiculus mus. Proin vel arcu eu odio tristique", SalePrice = 13.98M },
                new Product() { UPC = "411570", Code = "JBO153", Name = "at auctor ullamcorper,", Description = "gravida mauris ut mi. Duis risus odio, auctor vitae,", SalePrice = 17.59M },
                new Product() { UPC = "289174", Code = "GWP828", Name = "Nullam feugiat", Description = "ligula. Aenean gravida nunc sed pede. Cum", SalePrice = 12.88M },
                new Product() { UPC = "604560", Code = "XKS444", Name = "Proin non massa non", Description = "tincidunt pede ac urna. Ut tincidunt vehicula", SalePrice = 5.7M },
                new Product() { UPC = "154057", Code = "WHT484", Name = "diam vel arcu. Curabitur", Description = "nulla. Cras eu tellus eu augue porttitor", SalePrice = 17.52M },
                new Product() { UPC = "837784", Code = "CVK883", Name = "ipsum. Donec", Description = "justo nec ante. Maecenas mi felis,", SalePrice = 16.76M },
                new Product() { UPC = "169290", Code = "ZHM657", Name = "sem mollis dui,", Description = "sapien imperdiet ornare. In faucibus. Morbi", SalePrice = 12.17M },
                new Product() { UPC = "621936", Code = "FCE463", Name = "et netus et malesuada", Description = "congue, elit sed consequat", SalePrice = 0.35M },
                new Product() { UPC = "135049", Code = "TCM357", Name = "quis, tristique ac, eleifend", Description = "posuere cubilia Curae; Donec tincidunt.", SalePrice = 13.03M }

            };
        }
        
        public bool Delete(Product record)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            foreach (var prod in produits)
            {
                yield return prod;
            }
        }

        public bool Insert(Product record)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrInsert(Product record)
        {
            throw new NotImplementedException();
        }
    }
}
