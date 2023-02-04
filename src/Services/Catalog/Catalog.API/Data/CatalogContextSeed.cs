using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Dell PowerEdge R750",
                    Summary = "The Dell PowerEdge R750 is a 2U rack server that is designed for demanding workloads and high performance computing. It supports up to two Intel Xeon Scalable processors, up to 3TB of memory, and a variety of storage options including NVMe SSDs and SATA/SAS drives. The server also features advanced security features such as secure boot and support for TPM 2.0.",
                    Description = "The Dell PowerEdge R750 is a high-performance 2U rack server designed for demanding workloads. It offers a range of storage options, support for up to two Intel Xeon Scalable processors, and a maximum of 3TB of memory. The server is equipped with advanced security features such as secure boot and TPM 2.0 support.",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Rack Server"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Dell PowerEdge VRTX RACK",
                    Summary = "The Dell PowerEdge VRTX is a compact, integrated rack solution for small and medium-sized businesses. It combines servers, storage, and networking into a single, scalable platform, and is designed to be easy to manage and maintain.",
                    Description = "The VRTX supports up to four blade servers and up to 12TB of internal storage, and features redundant power and cooling, as well as advanced security features. Additionally, it supports virtualization and cloud computing, making it a versatile solution for a wide range of workloads and use cases.",
                    ImageFile = "product-2.png",
                    Price = 840.00M,
                    Category = "Blade Server"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "HP Proliant BL460c",
                    Summary = "The HP ProLiant BL460c is a server blade designed for data centers. It features two Intel Xeon processors, up to 768 GB of memory, and multiple storage options including solid-state drives and SAS/SATA drives.",
                    Description = "The BL460c has a compact form factor, making it suitable for dense computing environments. It also offers remote management capabilities and can be integrated into HP's BladeSystem infrastructure for easy deployment and management. The BL460c is commonly used for enterprise applications such as database, virtualization, and cloud computing.\n\n\n\n",
                    ImageFile = "product-3.png",
                    Price = 650.00M,
                    Category = "Blade Server"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "HPE ProLiant DL Gen11",
                    Summary = "The HPE ProLiant DL Gen11 is a line of enterprise-class servers developed by Hewlett Packard Enterprise (HPE). These servers are designed for mission-critical workloads, with a focus on high performance, reliability, and security.",
                    Description = "They feature the latest Intel Xeon Scalable processors, as well as support for up to 3TB of memory and a range of storage options, including NVMe drives and solid-state storage. Additionally, the ProLiant DL Gen11 servers offer advanced security features, such as the HPE Silicon Root of Trust and HPE Secure Compute Lifecycle, to help protect against cyber threats.",
                    ImageFile = "product-4.png",
                    Price = 470.00M,
                    Category = "Rack Server"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Dell PowerVault LTO-7",
                    Summary = "Dell PowerVault LTO-7 is a tape-based data storage solution designed for data backup and archiving. It uses Linear Tape-Open (LTO) technology and offers a capacity of 6 TB (compressed) per tape.",
                    Description = "The LTO-7 tapes offer fast data transfer speeds and enhanced data protection through hardware-based encryption. The PowerVault LTO-7 tape drives are compatible with multiple operating systems and provide easy integration into existing backup and archive workflows. This makes it a cost-effective and reliable option for businesses to store large amounts of data for long-term preservation.",
                    ImageFile = "product-5.png",
                    Price = 380.00M,
                    Category = "Tape Storage"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "HP SB3000c",
                    Summary = "The HP SB3000c is a storage blade designed for use in HP BladeSystem c-Class enclosures. It is a high-performance, dense, and scalable storage solution that can support various storage protocols, including Fibre Channel and iSCSI.",
                    Description = "The SB3000c is designed to provide high availability, data protection, and manageability to meet the demands of virtualized and cloud computing environments. With support for up to two SAS or SATA drives and flexible drive configurations, it provides a cost-effective solution for expanding the storage capacity of HP BladeSystem c-Class infrastructure.",
                    ImageFile = "product-6.png",
                    Price = 240.00M,
                    Category = "Tape Storage"
                }
            };
        }
    }
}
