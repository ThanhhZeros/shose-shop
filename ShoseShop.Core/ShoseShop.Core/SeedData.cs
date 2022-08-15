using Microsoft.EntityFrameworkCore;
using ShoseShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoseShop.Core
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogCategory>().HasData(
                    new BlogCategory() { BlogCategoryID = 1, BlogCategoryName = "Làm đẹp", IsActive = true },
                    new BlogCategory() { BlogCategoryID = 2, BlogCategoryName = "Bảo quản giày", IsActive = true }
                );


            modelBuilder.Entity<Blog>().HasData(
                    new Blog()
                    {
                        BlogID = 1,
                        BlogCategoryID = 1,
                        BlogName = "Mua giày ở đâu?",
                        Images = "tintuc1.jp",
                        Content = "1 SneakerLand\nNằm trên phố Thịnh Yên,100 % authentic," +
                        "Sneaker Land được nhiều bạn trẻ biết đến là cửa hàng chuyên bán và order giày sneakers và phụ kiện.Sneaker Land cam kêt mang đến cho khách hàng các sản phẩm giày chính hãng," +
                        "US shipped.Rất nhiều khách hàng đã mua," +
                        "trải nghiệm và đánh giá về nguồn gốc của hàng nên bạn không cần phải lo lắng chút nào khi mua giày tại đây.Điều đặc biệt khiến SneakerLand được nhiều người biết đến bởi tại đây cung " +
                        "cấp nhiều mẫu mã giày đa dạng kèm các loại phụ kiện phù hợp với cá tính riêng của từng khách hàng.Từ những mẫu giày basic đến những chiếc giày cá tính,phá cách," +
                        "cửa hàng luôn update và đưa đến cho khách hàng những mẫu giày mới thường xuyên nên bạn có thể tìm được mẫu giày mới," +
                        "ưng ý và chất lượng nhất tại đây.",
                        IsActive = true
                    },
                    new Blog()
                    {
                        BlogID = 2,
                        BlogCategoryID = 1,
                        BlogName = "Giữ phong độ cho sneaker trắng ra sao",
                        Images = "tintuc2.jpg",
                        Content = "Những cách bảo quản giày trắng\n" +
                        "TRÁNH ÁNH SÁNG TRỰC TIẾP CỦA MẶT TRỜI\n" +
                        "Với những đôi giày Sneaker màu thì ánh sáng mặt trời chính là thủ phạm hằng đầu khiến cho màu phai nhanh.Còn đối với những chiếc giày trắng thì ánh nắng lại khiến khả năng bị ố vàng trở nên cao hơn.Vì vậy không phải nhắc nhở bạn là không được đeo giày trắng vào ngày nắng," +
                        "mà việc bạn cất giữ đôi giày làm sao để ánh nắng không chiếu vào khi không sử dụng nhé." +
                        "TUYỆT ĐỐI KHÔNG GIẶT GIÀY BẰNG MÁY GIẶT\n" +
                        "Giày trắng hay bất kể đôi giày nào khác bạn cũng không được lười và bỏ chúng vào máy giặt.Như vậy là khiến cho giày bị mất form," +
                        "vải sẽ bị sờn,còn đối với loại giày da,da sẽ bị bong tróc.Không kể tới việc giày có đế cứng sẽ làm cho máy giặt nhà bạn phải chật vật đấy.Tốt nhất luôn nói không với giặt giày trắng bằng máy giặt nhé." +
                        "GIẶT GIÀY BẰNG NƯỚC ẤM\n" +
                        "Nhiệt độ ấm vừa phải là thích hợp nhất để bạn giặt giày.Đối với những sợi dây giày thì bạn nên ngâm chúng vào nước ầm pha bột giặt và vò bằng tay.Còn với đôi dày của bạn thì dùng bàn chải thấm nước giặt rồi chà nhẹ nhàng.",
                        IsActive = true
                    },
                    new Blog()
                    {
                        BlogID = 3,
                        BlogCategoryID = 1,
                        BlogName = "Cách buộc dây giày",
                        Images = "tintuc3.jpg",
                        Content = "Những cách bảo quản giày trắng\n" +
                        "TRÁNH ÁNH SÁNG TRỰC TIẾP CỦA MẶT TRỜI\n" +
                        "Với những đôi giày Sneaker màu thì ánh sáng mặt trời chính là thủ phạm hằng đầu khiến cho màu phai nhanh.Còn đối với những chiếc giày trắng thì ánh nắng lại khiến khả năng bị ố vàng trở nên cao hơn.Vì vậy không phải nhắc nhở bạn là không được đeo giày trắng vào ngày nắng," +
                        "mà việc bạn cất giữ đôi giày làm sao để ánh nắng không chiếu vào khi không sử dụng nhé." +
                        "TUYỆT ĐỐI KHÔNG GIẶT GIÀY BẰNG MÁY GIẶT\n" +
                        "Giày trắng hay bất kể đôi giày nào khác bạn cũng không được lười và bỏ chúng vào máy giặt.Như vậy là khiến cho giày bị mất form," +
                        "vải sẽ bị sờn,còn đối với loại giày da,da sẽ bị bong tróc.Không kể tới việc giày có đế cứng sẽ làm cho máy giặt nhà bạn phải chật vật đấy.Tốt nhất luôn nói không với giặt giày trắng bằng máy giặt nhé." +
                        "GIẶT GIÀY BẰNG NƯỚC ẤM\n" +
                        "Nhiệt độ ấm vừa phải là thích hợp nhất để bạn giặt giày.Đối với những sợi dây giày thì bạn nên ngâm chúng vào nước ầm pha bột giặt và vò bằng tay.Còn với đôi dày của bạn thì dùng bàn chải thấm nước giặt rồi chà nhẹ nhàng.",
                        IsActive = true
                    }
               ); ;

            modelBuilder.Entity<Category>().HasData(

                    new Category() { CategoryID = 1, CategoryName = "Giày Nike", IsActive = true },
                    new Category() { CategoryID = 2, CategoryName = "Giày Adidas", IsActive = true },
                    new Category() { CategoryID = 3, CategoryName = "Giày Vans", IsActive = true },
                    new Category() { CategoryID = 2, CategoryName = "Giày Converse", IsActive = true },
                    new Category() { CategoryID = 2, CategoryName = "Giày Puma", IsActive = true },
                    new Category() { CategoryID = 2, CategoryName = "Giày Balenciaga", IsActive = true }

                );



            modelBuilder.Entity<Role>().HasData(
                  new Role() { RoleID = 1, RoleName = "Admin", IsActive = true },
                  new Role() { RoleID = 2, RoleName = "Nhân viên", IsActive = true },
                  new Role() { RoleID = 3, RoleName = "Khách hàng", IsActive = true }

              );

            modelBuilder.Entity<Product>().HasData(
                  new Product() { ProductID = 1, CategoryID = 1, ProductName = "Giày Thể Thao XSPORT Ni.ke air force 1 Rep 1:1 HFV753", Descriptions = "Giày Thể Thao XSPORT Ni.ke air force 1 Rep 1:1 thiết kế đẹp mắt, kiểu dáng hiện đại. Với đôi giày thời trang này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 550000, IsActive = true }, 
                  new Product() { ProductID = 2, CategoryID = 1, ProductName = "Giày Thể Thao XSPORT Ni.ke Jordan 1 F1 Running", Descriptions = "Giày Thể Thao XSPORT Ni.ke Jordan 1 F1 chất liệu cao cấp, bền đẹp theo thời gian. Thiết kế thời trang. Kiểu dáng phong cách.Phối màu tinh tế và đẹp mắt. Độ bền cao. Dễ phối đồ. Với đôi giày thời trang này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 350000, IsActive = true },
                  new Product() { ProductID = 3, CategoryID = 1, ProductName = "Giày Thể Thao XSPORT Ni.ke Jordan Low REP Running", Descriptions = "Giày Thể Thao XSPORT Ni.ke Jordan Low REP có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 750000, IsActive = true },
                  new Product() { ProductID = 4, CategoryID = 1, ProductName = "Giày Thể Thao Nike Air Max Verona Running", Descriptions = "Giày Thể Thao Nike Air Max Verona Pink/Black Màu Đen Hồng thiết kế đẹp mắt, kiểu dáng hiện đại. Với đôi giày thời trang này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 550000,IsActive = true },
                  new Product() { ProductID = 5, CategoryID = 1, ProductName = "Giày Thể Thao Nike Air Force 1 Shadow Crimson Tint", Descriptions = "Giày Thể Thao Nike Air Force 1 Shadow Crimson Tint CI0919-107 với thiết kế thời trang từ thương hiệu Nike nổi tiếng của Mỹ. Giày Thể Thao Nike Air Force 1 Shadow Crimson Tint CI0919-107  sở hữu gam màu trẻ trung cùng chất liệu cao cấp sẽ cho bạn trải nghiệm tuyệt vời khi đi lên chân.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 6, CategoryID = 1, ProductName = "Giày Nike Jordan 1 Mid University 76WBFHW", Descriptions = "Giày Thể Thao Nike Air Jordan 1 Mid GS  554725-175 có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ. Giày Nike Air Jordan 1 Mid GS  554725-175 được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 7, CategoryID = 1, ProductName = "Giày Thể Thao Nike Air Jordan 1 HG9WEFRHW", Descriptions = "Giày Thể Thao Nike Air Jordan 1 có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 8, CategoryID = 1, ProductName = "Giày Nike Air Jordan 1 Mid Se Union Black Toe", Descriptions = "Giày Nike Air Jordan 1 Mid Se Union Black Toe có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 9, CategoryID = 1, ProductName = "Giày Nike Dunk Low SE Multi Camo 97HFSJGW", Descriptions = "Giày Nike Dunk Low SE Multi Camocó thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 10, CategoryID = 1, ProductName = "Giày Thể Thao Nike Air Max 1 Se Volt Rush", Descriptions = "Giày Thể Thao Nike Air Max 1 Se Volt Rush có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 11, CategoryID = 1, ProductName = "GiàyThể Thao Nike Air Zoom Structure GHKS97463", Descriptions = "Giày Thể Thao Nike Air Zoom Structure có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 12, CategoryID = 1, ProductName = "Giày Thể Thao Nike Downshifter 10 Running SHGFSK963", Descriptions = "Giày Thể Thao Nike Air Downshifter 10 Running có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 13, CategoryID = 1, ProductName = "Giày Thể Thao Nike Epic React Infinity Fk Phối Màu", Descriptions = "Giày Thể Thao Nike Epic React Infinity Fk Phối Màu có thiết kế trẻ trung, năng động đến từ thương hiệu Nike nổi tiếng của Mỹ được làm từ chất liệu cao cấp, bền đẹp trong suốt quá trình sử dụng.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 14, CategoryID = 2, ProductName = "Giày Thể Thao XSPORT Adi.das Alpha.bounce Instinct M", Descriptions = "Giày Thể Thao XSPORT Adi.das Alpha.bounce Instinct M Phối Màu là đôi giày dành cho các chàng trai đam mê thể thao được thiết kế vô cùng hiện đại đến từ thương hiệu Adidas nổi tiếng. Sở hữu gam màu nổi bật cùng chất liệu cao cấp Adidas Harden Vol5 Futurenatural White FZ1071 mang lại cảm giác thoải mái khi vận động, chạy nhảy nhiều.", Price = 350000, IsActive = true },
                  new Product() { ProductID = 15, CategoryID = 2, ProductName = "Giày Thể Thao XSPORT Prophere Rep 1:1 57GFH", Descriptions = "'Giày Thể Thao XSPORT Prophere Replà mẫu giày hoài niệm phong cách hầm hố lấy cảm hứng từ nền văn hóa đại chúng của thập niên 90 của thương hiệu Adidas nổi tiếng.", Price = 500000, IsActive = true },
                  new Product() { ProductID = 16, CategoryID = 2, ProductName = "Giày Thể Thao XSPORT Ultra Boost 74321", Descriptions = "Giày Thể Thao XSPORT Ultra Boost là đôi giày cao cấp đến từ thương hiệu Adias nổi tiếng của nước Mỹ. Với đôi giày Vans Classic Sk8-Hi Black/White này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price =350000, IsActive = true },
                  new Product() { ProductID = 17, CategoryID = 2, ProductName = "Giày Thể Thao Adidas Runfalcon 125473", Descriptions = "Giày Thể Thao Adidas Runfalcon Màu Đen Trắng là đôi giày thể thao dành cho nam đến từ thương hiệu Adidas nổi tiếng của Đức. Adidas Runfalcon được thiết kế mang nét thể thao phóng đại, khỏe khoắn mang đầy nét năng động.", Price = 300000, IsActive = true },
                  new Product() { ProductID = 18, CategoryID = 2, ProductName = "Giày Thể Thao Adidas Original Stan Smith", Descriptions = "Giày Thể Thao Adidas Original Stan Smith M20324 Màu Trắng đến từ thương hiệu Adidas nổi tiếng của Đức. Adidas Original Stan Smith được thiết kế mang nét thể thao khỏe khoắn, năng động cho bạn trải nghiệm tuyệt vời khi đi lên chân.", Price = 700000, IsActive = true },
                  new Product() { ProductID = 19, CategoryID = 2, ProductName = "Giày Thể Thao Adidas Neo Cloudfoam Lite Racer Olive", Descriptions = "Giày Thể Thao Adidas Neo Cloudfoam Lite Racer Olive Màu Xanh Green là một trong những sản phẩm nổi tiếng của Adidas với thiết kế được tính toán tốt nhất dành cho người dùng: mềm mại, thoải mái, kiểu dáng thể thao trẻ trung, chất liệu bền đẹp. Với đôi giày thời trang này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 20, CategoryID = 2, ProductName = "Giày Thể Thao Adidas Ultraboost 20 USA", Descriptions = "Giày Thể Thao Adidas Ultraboost 20 USA Màu Trắng đến từ thương hiệu Adidas nổi tiếng của Đức. Adidas Ultraboost 20 USA được thiết kế mang nét thể thao khỏe khoắn, năng động cho bạn trải nghiệm tuyệt vời nhất khi đi lên chân.", Price = 600000, IsActive = true },
                  new Product() { ProductID = 21, CategoryID = 2, ProductName = "Giày Bóng Rổ Adidas Harden Vol5 Futurenatural", Descriptions = "Giày Bóng Rổ Adidas Harden Vol5 Futurenatural White FZ1071 Phối Màu là đôi giày dành cho các chàng trai đam mê thể thao được thiết kế vô cùng hiện đại đến từ thương hiệu Adidas nổi tiếng. Sở hữu gam màu nổi bật cùng chất liệu cao cấp Adidas Harden Vol5 Futurenatural White FZ1071 mang lại cảm giác thoải mái khi vận động, chạy nhảy nhiều.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 22, CategoryID = 2, ProductName = "Giày Thể Thao Adidas Falcon Lite Racer Olive", Descriptions = "Giày Thể Thao Adidas Falcon Grey Pink D96698 Màu Xám là mẫu giày hoài niệm phong cách hầm hố lấy cảm hứng từ nền văn hóa đại chúng của thập niên 90 của thương hiệu Adidas nổi tiếng.", Price = 400000, IsActive = true },
                  new Product() { ProductID = 23, CategoryID = 2, ProductName = "Giày Thể Thao Adidas D Rose 11 Lite Racer Olive", Descriptions = "Giày Thể Thao Adidas D Rose 11 FY9988 Màu Xanh được thiết kế hiện đại đến từ thương hiệu Adidas nổi tiếng. Với gam màu thanh lịch Adidas D Rose 11 FY9988 Màu Xanh cho bạn trở nên sành điệu và thật phong cách khi đi lên chân.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 24, CategoryID = 2, ProductName = "Giày Thể Thao Adidas D Rose 12Lite Racer Olive", Descriptions = "Giày Thể Thao Adidas D Rose 12 FY9988 Màu Xanh được thiết kế hiện đại đến từ thương hiệu Adidas nổi tiếng. Với gam màu thanh lịch Adidas D Rose 11 FY9988 Màu Xanh cho bạn trở nên sành điệu và thật phong cách khi đi lên chân.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 25, CategoryID = 2, ProductName = "Giày Thể Thao Adidas Pro Bounce 2019", Descriptions = "Giày Thể Thao Adidas Pro Bounce 2019 EE3898 Màu Đỏ được thiết kế hiện đại đến từ thương hiệu Adidas nổi tiếng. Với gam màu thanh lịch Adidas Pro Bounce 2019 EE3898 Màu Đỏ cho bạn trở nên sành điệu và thật phong cách khi đi lên chân.", Price = 650000, IsActive = true },
                  new Product() { ProductID = 26, CategoryID = 2, ProductName = "Giày Thể Thao Adidas X9000L3 H.RDY M", Descriptions = "Giày Thể Thao Adidas X9000L3 H.RDY M FY0798 Màu Trắng được thiết kế hiện đại đến từ thương hiệu Adidas nổi tiếng. Với gam màu thanh lịch Adidas X9000L3 H.RDY M FY0798 cho bạn trở nên sành điệu và thật phong cách khi đi lên chân.", Price = 750000, IsActive = true },
                  new Product() { ProductID = 27, CategoryID = 3, ProductName = "Giày Vans Mule Checkerboard GHJGBAK7463", Descriptions = "Giày Vans Mule Checkerboard Màu Xanh Navy là đôi giày Unisex dành cho cả nam và nữ đến từ thương hiệu Vans nổi tiếng của nước Mỹ. Với đôi giày Vans thời trang này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 550000, IsActive = true },
                  new Product() { ProductID = 28, CategoryID = 3, ProductName = "Giày Thể Thao Vans Classic SGHBSJ8752", Descriptions = "Giày Thể Thao Vans Classic Sk8-Hi Black/White Màu Đen là đôi giày cao cấp đến từ thương hiệu Vans nổi tiếng của nước Mỹ. Với đôi giày Vans Classic Sk8-Hi Black/White này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 1600000, IsActive = true },
                  new Product() { ProductID = 29, CategoryID = 3, ProductName = "Giày Vans Old Skool X J.Crew SDHGA8735", Descriptions = "Giày Vans Old Skool X J.Crew Reflecting Pond Màu Xanh là đôi giày cao cấp đến từ thương hiệu Vans nổi tiếng của nước Mỹ. Với đôi giày Vans Old Skool X J.Crew Reflecting Pond này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 1900000, IsActive = true },
                  new Product() { ProductID = 30, CategoryID = 3, ProductName = "Giày Thể Thao Vans Checkerboard Slip On", Descriptions = "Với kiểu dáng Style trẻ trung, đẹp mắt, mang đậm phong cách, cá tính cho người mang. Phần đế giày có độ ma sát cao hạn chế trơn trượt cho người sử dụng.Không chỉ dành cho người yêu sneaker, đôi giày còn phù hợp với những tín đồ đam mê thể thao với phong cách thời trang năng động, đậm nét cá tính.", Price = 1300000, IsActive = true },
                  new Product() { ProductID = 31, CategoryID = 3, ProductName = "Giày Vans Asher All White FHSJFB8W4T6", Descriptions = "Giày Vans Ward Triple White Màu Trắng là đôi giày cao cấp đến từ thương hiệu Vans nổi tiếng của nước Mỹ. Với đôi giày Vans Ward Triple White này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 1400000, IsActive = true },
                  new Product() { ProductID = 32, CategoryID = 3, ProductName = "Giày Sneakers Vans Style 36 Marshmallow Blue Màu Trắng", Descriptions = "Giày Sneaker Vans Style 36 Marshmallow Blue Màu Trắng Size 41 đến từ thương hiệu Vans nổi tiếng của nước Mỹ. Với đôi giày Sneaker Vans thời trang này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 2500000, IsActive = true },
                  new Product() { ProductID = 33, CategoryID = 3, ProductName = "Giày Vans Ward Triple White Màu Trắng", Descriptions = "Giày Vans Ward Triple White Màu Trắng là đôi giày cao cấp đến từ thương hiệu Vans nổi tiếng của nước Mỹ. Với đôi giày Vans Ward Triple White này chắc chắn bạn sẽ trở nên nổi bật và cuốn hút hơn.", Price = 1500000, IsActive = true },
                  new Product() { ProductID = 34, CategoryID = 3, ProductName = "Giày Vans Vault Old Skool – Marshmallow Multicolor Màu Trắng", Descriptions = "Giày Vans Vault Old Skool – Marshmallow Multicolor Màu Trắng đến từ thương hiệu Vans nổi tiếng của nước Mỹ, với thiết kế thời trang đôi giày sẽ cho bạn trải nghiệm tuyệt vời nhất khi đi lên chân.", Price = 2600000, IsActive = true },
                  new Product() { ProductID = 35, CategoryID = 4, ProductName = "Giày Thể Thao Converse All-Court - 168785C Màu Đen", Descriptions = "Giày Thể Thao Converse All-Court - 168785C Màu Đen sản phẩm đến từ thương hiệu Converse nổi tiếng của Mỹ. Với thiết kế thời trang, đôi giày đang nhận được sự yêu thích của rất nhiều bạn trẻ.", Price = 2600000, IsActive = true },
                  new Product() { ProductID = 36, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star Lift Leather Low 561680C", Descriptions = "Giày Converse Chuck Taylor All Star Lift Leather Low 561680C Màu Trắng là sản phẩm đến từ thương hiệu Converse nổi tiếng của Mỹ. Với thiết kế thời trang cùng màu sắc thanh lịch đôi giày đang nhận được sự yêu thích của rất nhiều bạn trẻ.", Price = 2600000, IsActive = true },
                  new Product() { ProductID = 37, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star 1970s", Descriptions = "Giày Converse Chuck Taylor All Star 1970s Colors Vintage Canvas - 168504V Màu Nâu Nhạt với thiết kế Độc - Lạ - Phá cách đến từ thương hiệu Converse nổi tiếng của Mỹ. Với gam màu thanh lịch Converse Chuck Taylor đang là item HOT được nhiều bạn trẻ săn đón.", Price = 2500000, IsActive = true },
                  new Product() { ProductID = 38, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star CX 168566C Màu Xanh Navy", Descriptions = "Giày Converse Chuck Taylor All Star CX 168566C Màu Xanh Navy sản phẩm đến từ thương hiệu Converse nổi tiếng của Mỹ. Với thiết kế Độc - Lạ - Phá cách, cùng gam màu nổi bật đôi giày đang nhận được sự quan tâm từ rất nhiều các bạn trẻ.", Price = 2000000, IsActive = true },
                  new Product() { ProductID = 39, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star 1970s Renew - 168615C Màu Vàng", Descriptions = "Giày Converse Chuck Taylor All Star 1970s Renew - 168615C Màu Vàng với thiết kế Độc - Lạ - Phá cách đến từ thương hiệu Converse nổi tiếng của Mỹ. Với gam màu nổi bật Converse Chuck Taylor đang là item HOT được nhiều bạn trẻ săn đón.", Price = 2550000, IsActive = true },
                  new Product() { ProductID = 40, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star CX 168568C", Descriptions = "Giày Converse Chuck Taylor All Star CX 168568C Màu Đen sản phẩm đến từ thương hiệu Converse nổi tiếng của Mỹ. Với thiết kế thời trang, đôi giày đang nhận được sự yêu thích của rất nhiều bạn trẻ.", Price = 3000000, IsActive = true },
                  new Product() { ProductID = 41, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star Renew - 168593V Màu Xanh Green", Descriptions = "Giày Converse Chuck Taylor All Star Renew - 168593V Màu Xanh Green sản phẩm đến từ thương hiệu Converse nổi tiếng của Mỹ. Với thiết kế Độc - Lạ - Phá cách, cùng gam màu nổi bật đôi giày đang nhận được sự quan tâm từ rất nhiều các bạn trẻ.", Price = 1800000, IsActive = true },
                  new Product() { ProductID = 42, CategoryID = 4, ProductName = "Giày Converse CDG Play X Chuck Taylor 1970s Cream White", Descriptions = "Giày Converse CDG Play X Chuck Taylor 1970s Cream White 70 Low 150207C Màu Trắng với thiết kế Độc - Lạ - Phá cách đến từ thương hiệu Converse nổi tiếng của Mỹ. Với gam màu thanh lịch Converse CDG Play X Chuck Taylor 1970s Cream White 70 Low 150207C  đang là item HOT được nhiều bạn trẻ săn đón.", Price = 1500000, IsActive = true },
                  new Product() { ProductID = 43, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star CX - 168570C Màu Vàng", Descriptions = "Giày Converse Chuck Taylor All Star CX - 168570C Màu Vàng sản phẩm đến từ thương hiệu Converse nổi tiếng của Mỹ. Với thiết kế thời trang cùng màu sắc nổi bật đôi giày đang nhận được sự yêu thích của rất nhiều bạn trẻ.", Price = 1900000, IsActive = true },
                  new Product() { ProductID = 44, CategoryID = 4, ProductName = "Giày Converse Chuck Taylor All Star CX - 168570C Màu Vàng", Descriptions = "Giày Thể Thao Converse 1970s High Black Fire Màu Đen Đỏ sản phẩm đến từ thương hiệu Converse nổi tiếng của Mỹ. Với thiết kế Độc - Lạ - Phá cách,  đôi giày đang nhận được sự quan tâm từ rất nhiều các bạn trẻ.", Price = 2700000, IsActive = true },
                  new Product() { ProductID = 45, CategoryID = 5, ProductName = "Giày Thể Thao Puma RS-X X3 Puzzle Multi 371570-04", Descriptions = "Giày Thể Thao Puma RS-X X3 Puzzle Multi 371570-04 với thiết kế trẻ trung đến từ thương hiệu Puma nổi tiếng của Đức. Giày Puma RS-X X3 sẽ cho bạn những trải nghiệm tuyệt vời khi đi lên chân.", Price = 2000000, IsActive = true },
                  new Product() { ProductID = 46, CategoryID = 5, ProductName = "Giày Thể Thao Puma Muse X2 Metallic 37083802 Màu Trắng", Descriptions = "Giày Thể Thao Puma Muse X2 Metallic 37083802 Màu Trắng với thiết kế trẻ trung đến từ thương hiệu Puma nổi tiếng của Đức. Giày Puma Muse X2 Metallic Màu Trắng sẽ cho bạn những trải nghiệm tuyệt vời khi đi lên chân.", Price = 1700000, IsActive = true },
                  new Product() { ProductID = 47, CategoryID = 5, ProductName = "Giày Thể Thao Puma Oslo-City Lux Màu Trắng", Descriptions = "Giày Thể Thao Puma Oslo-City Lux Màu Trắng với thiết kế trẻ trung đến từ thương hiệu Puma nổi tiếng của Đức. Giày Puma Oslo-City Lux được làm từ chất liệu cao cấp sẽ cho bạn trải nghiệm tuyệt vời khi đi lên chân.", Price = 1990000, IsActive = true },
                  new Product() { ProductID = 48, CategoryID = 5, ProductName = "Giày Puma Ralph Sampson Màu Trắng", Descriptions = "Giày Puma Ralph Sampson Màu TrắngSize 41 với thiết kế trẻ trung được nhiều tín đồ thời trang săn đón. Với gam màu sang trọng PPuma Ralph Sampson cho bạn thêm năng động và nổi bật.", Price = 1700000, IsActive = true },
                  new Product() { ProductID = 49, CategoryID = 5, ProductName = "Giày Thể Thao Puma Caracal Suede Màu Đen", Descriptions = "Giày Thể Thao Puma Caracal Suede Màu Đen với thiết kế trẻ trung được nhiều tín đồ thời trang săn đón. Với gam màu sang trọng PPuma Ralph Sampson cho bạn thêm năng động và nổi bật.", Price = 1700000, IsActive = true },
                  new Product() { ProductID = 50, CategoryID = 5, ProductName = "Giày Thể Thao Puma Smash V2 Black Màu Đen Trắng", Descriptions = "Giày Thể Thao Puma Smash V2 Black Màu Đen Trắng với thiết kế trẻ trung được nhiều tín đồ thời trang săn đón. Với gam màu sang trọng PPuma Ralph Sampson cho bạn thêm năng động và nổi bật.", Price = 2000000, IsActive = true },
                  new Product() { ProductID = 51, CategoryID = 5, ProductName = "Giày Thể Thao Puma Roma Scuderia Ferrari", Descriptions = "Giày Thể Thao Puma Roma Scuderia Ferrari với thiết kế trẻ trung được nhiều tín đồ thời trang săn đón. Với gam màu sang trọng PPuma Ralph Sampson cho bạn thêm năng động và nổi bật.", Price = 2250000, IsActive = true },
                  new Product() { ProductID = 52, CategoryID = 5, ProductName = "Giày Puma Bari Mule Men", Descriptions = "Giày Puma Bari Mule Men với thiết kế trẻ trung được nhiều tín đồ thời trang săn đón. Với gam màu sang trọng PPuma Ralph Sampson cho bạn thêm năng động và nổi bật.", Price = 1500000, IsActive = true },
                  new Product() { ProductID = 53, CategoryID = 5, ProductName = "Giày Thể Thao Puma Scuderia Ferrari Speed HYBRID Running", Descriptions = "Giày Thể Thao Puma Scuderia Ferrari Speed HYBRID Running với thiết kế trẻ trung được nhiều tín đồ thời trang săn đón. Với gam màu sang trọng PPuma Ralph Sampson cho bạn thêm năng động và nổi bật.", Price = 2600000, IsActive = true },
                  new Product() { ProductID = 54, CategoryID = 5, ProductName = "Giày Thể Thao Puma Basket 90680 Lux Màu Trắng", Descriptions = "Giày Thể Thao Puma Basket 90680 Lux Màu Trắng với thiết kế trẻ trung được nhiều tín đồ thời trang săn đón. Với gam màu sang trọng PPuma Ralph Sampson cho bạn thêm năng động và nổi bật.", Price = 1550000, IsActive = true }
              );


            modelBuilder.Entity<ImageProduct>().HasData(
                 new ImageProduct() { ImageID = 1, ProductID = 1, Images = "nikeairforcexanh.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 2, ProductID = 1, Images = "nikeairforcehong.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 3, ProductID = 1, Images = "nikeairforcexam.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 4, ProductID = 2, Images = "jordancam.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 5, ProductID = 2, Images = "jordanden.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 6, ProductID = 2, Images = "jordando.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 7, ProductID = 2, Images = "jordantim.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 8, ProductID = 3, Images = "jordanlowxanhden.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 9, ProductID = 3, Images = "jordanlowxam.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 10, ProductID = 3, Images = "jordanlowtrang.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 11, ProductID = 4, Images = "NIKE1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 12, ProductID = 5, Images = "NIKE2.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 13, ProductID = 6, Images = "NIKE3.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 14, ProductID = 7, Images = "NIKE4.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 15, ProductID = 8, Images = "NIKE5.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 16, ProductID = 9, Images = "NIKE6.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 17, ProductID = 10, Images = "NIKE7.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 18, ProductID = 11, Images = "NIKE8.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 19, ProductID = 12, Images = "NIKE9.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 20, ProductID = 13, Images = "NIKE10.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 21, ProductID = 14, Images = "adiasalphaden.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 22, ProductID = 14, Images = "adiasalphado.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 23, ProductID = 14, Images = "adiasalphaxam.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 24, ProductID = 14, Images = "adiasalphaxamden.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 25, ProductID = 15, Images = "prophexanhduong.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 26, ProductID = 15, Images = "prophehong.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 27, ProductID = 15, Images = "prophexanhreu.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 28, ProductID = 15, Images = "prophedo.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 29, ProductID = 15, Images = "propheden.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 30, ProductID = 15, Images = "prophekecam.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 31, ProductID = 16, Images = "ultrahong.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 32, ProductID = 16, Images = "ultratrang.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 33, ProductID = 16, Images = "ultraxam.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 34, ProductID = 16, Images = "ultraden.PNG", IsActive = true },
                 new ImageProduct() { ImageID = 35, ProductID = 17, Images = "AD1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 36, ProductID = 18, Images = "AD2.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 37, ProductID = 19, Images = "AD3.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 38, ProductID = 20, Images = "AD4.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 39, ProductID = 21, Images = "AD5.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 40, ProductID = 22, Images = "AD6.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 41, ProductID = 23, Images = "AD7.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 42, ProductID = 24, Images = "AD8.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 43, ProductID = 25, Images = "AD9.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 44, ProductID = 26, Images = "AD10.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 45, ProductID = 27, Images = "VA1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 46, ProductID = 27, Images = "VA1.1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 47, ProductID = 28, Images = "VA2.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 48, ProductID = 29, Images = "VA3.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 49, ProductID = 29, Images = "VA3.1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 50, ProductID = 30, Images = "VA4.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 51, ProductID = 30, Images = "VA4.1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 52, ProductID = 31, Images = "VA5.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 53, ProductID = 32, Images = "VA6.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 54, ProductID = 32, Images = "VA6.1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 55, ProductID = 33, Images = "VA7.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 56, ProductID = 34, Images = "VA8.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 57, ProductID = 35, Images = "CV1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 58, ProductID = 36, Images = "CV2.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 59, ProductID = 37, Images = "CV3.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 60, ProductID = 37, Images = "CV3.1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 61, ProductID = 37, Images = "CV3.2.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 62, ProductID = 38, Images = "CV4.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 63, ProductID = 39, Images = "CV5.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 64, ProductID = 40, Images = "CV6.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 65, ProductID = 41, Images = "CV7.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 66, ProductID = 42, Images = "CV8.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 67, ProductID = 43, Images = "CV9.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 68, ProductID = 44, Images = "CV10.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 69, ProductID = 45, Images = "PA1.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 70, ProductID = 46, Images = "PA2.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 71, ProductID = 47, Images = "PA3.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 72, ProductID = 48, Images = "PA4.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 73, ProductID = 49, Images = "PA5.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 74, ProductID = 50, Images = "PA6.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 75, ProductID = 51, Images = "PA7.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 76, ProductID = 52, Images = "PA8.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 77, ProductID = 53, Images = "PA9.jpg", IsActive = true },
                 new ImageProduct() { ImageID = 78, ProductID = 54, Images = "PA10.jpg", IsActive = true }
             );

            modelBuilder.Entity<ProductDetail>().HasData(
                 new ProductDetail() { SizeID = 1, ImageID = 1, Size = 36, AmountInput=5, IsActive = true },
                 new ProductDetail() { SizeID = 2, ImageID = 1, Size = 37, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 3, ImageID = 1, Size = 38, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 4, ImageID = 1, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 5, ImageID = 1, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 6, ImageID = 2, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 7, ImageID = 2, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 8, ImageID = 2, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 9, ImageID = 2, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 10, ImageID = 2, Size = 40, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 11, ImageID = 3, Size = 35, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 12, ImageID = 3, Size = 37, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 13, ImageID = 3, Size = 38, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 14, ImageID = 3, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 15, ImageID = 3, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 16, ImageID = 4, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 17, ImageID = 4, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 18, ImageID = 4, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 19, ImageID = 4, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 20, ImageID = 5, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 21, ImageID = 5, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 22, ImageID = 5, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 23, ImageID = 5, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 24, ImageID = 6, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 25, ImageID = 6, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 26, ImageID = 6, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 27, ImageID = 6, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 28, ImageID = 4, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 29, ImageID = 4, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 30, ImageID = 5, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 31, ImageID = 5, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 32, ImageID = 6, Size = 37, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 33, ImageID = 6, Size = 38, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 34, ImageID = 6, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 35, ImageID = 7, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 36, ImageID = 7, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 37, ImageID = 7, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 38, ImageID = 8, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 39, ImageID = 8, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 40, ImageID = 9, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 41, ImageID = 10, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 42, ImageID = 10, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 43, ImageID = 10, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 44, ImageID = 11, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 45, ImageID = 11, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 46, ImageID = 12, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 47, ImageID = 12, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 48, ImageID = 12, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 49, ImageID = 13, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 50, ImageID = 14, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 51, ImageID = 15, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 52, ImageID = 15, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 53, ImageID = 16, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 54, ImageID = 17, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 55, ImageID = 17, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 56, ImageID = 18, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 57, ImageID = 18, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 58, ImageID = 19, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 59, ImageID = 20, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 60, ImageID = 21, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 61, ImageID = 22, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 62, ImageID = 23, Size = 37, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 63, ImageID = 23, Size = 38, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 64, ImageID = 23, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 65, ImageID = 24, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 66, ImageID = 25, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 67, ImageID = 26, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 68, ImageID = 27, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 69, ImageID = 28, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 70, ImageID = 29, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 71, ImageID = 30, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 72, ImageID = 31, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 73, ImageID = 31, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 74, ImageID = 32, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 75, ImageID = 33, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 76, ImageID = 34, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 77, ImageID = 35, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 78, ImageID = 36, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 79, ImageID = 37, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 80, ImageID = 38, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 81, ImageID = 39, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 82, ImageID = 39, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 83, ImageID = 40, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 84, ImageID = 41, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 85, ImageID = 41, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 86, ImageID = 42, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 87, ImageID = 42, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 88, ImageID = 42, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 89, ImageID = 43, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 90, ImageID = 44, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 91, ImageID = 45, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 92, ImageID = 45, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 93, ImageID = 46, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 94, ImageID = 47, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 95, ImageID = 47, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 96, ImageID = 48, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 97, ImageID = 48, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 98, ImageID = 49, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 99, ImageID = 50, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 100, ImageID = 51, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 101, ImageID = 52, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 102, ImageID = 53, Size = 37, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 103, ImageID = 53, Size = 38, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 104, ImageID = 53, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 105, ImageID = 54, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 106, ImageID = 55, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 107, ImageID = 56, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 108, ImageID = 57, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 109, ImageID = 58, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 110, ImageID = 59, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 111, ImageID = 60, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 112, ImageID = 61, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 113, ImageID = 61, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 114, ImageID = 62, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 115, ImageID = 63, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 116, ImageID = 64, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 117, ImageID = 65, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 118, ImageID = 66, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 119, ImageID = 67, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 120, ImageID = 68, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 121, ImageID = 69, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 122, ImageID = 70, Size = 38, AmountInput = 7, IsActive = true },
                 new ProductDetail() { SizeID = 123, ImageID = 71, Size = 39, AmountInput = 8, IsActive = true },
                 new ProductDetail() { SizeID = 124, ImageID = 72, Size = 39, AmountInput = 3, IsActive = true },
                 new ProductDetail() { SizeID = 125, ImageID = 73, Size = 40, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 126, ImageID = 74, Size = 36, AmountInput = 6, IsActive = true },
                 new ProductDetail() { SizeID = 127, ImageID = 75, Size = 37, AmountInput = 10, IsActive = true },
                 new ProductDetail() { SizeID = 128, ImageID = 76, Size = 38, AmountInput = 5, IsActive = true },
                 new ProductDetail() { SizeID = 129, ImageID = 77, Size = 39, AmountInput = 11, IsActive = true },
                 new ProductDetail() { SizeID = 130, ImageID = 78, Size = 36, AmountInput = 9, IsActive = true },
                 new ProductDetail() { SizeID = 131, ImageID = 78, Size = 37, AmountInput = 10, IsActive = true }
             );

            modelBuilder.Entity<Orders>().HasData(
                  new Orders() { OrderID = 1, UserID = 1, UserName = "Nguyễn Văn A", Phone = "0987656432", Address = "Cầu giấy, Hà Nội", Email = "namnguyen@gmail.com",Note = "Bộ phim lấy mốc thời gian ha.", DateCreate = new DateTime(2022, 03, 04), IsActive = true },
                  new Orders() { OrderID = 2, UserID = 2, UserName = "Nguyễn Văn B", Phone = "0987656432", Address = "Cầu giấy, Hà Nội", Email = "namnguyen1@gmail.com", Note = "Bộ phim lấy mốc thời gian ha.", DateCreate = new DateTime(2022, 03, 04), IsActive = true }
          );

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail() { OrderID = 1, SizeID = 1, ImageID = 1, Amount = 1, IsActive = true },
                new OrderDetail() { OrderID = 1, SizeID = 10, ImageID = 5, Amount = 1, IsActive = true }
          );

            modelBuilder.Entity<User>().HasData(
                new User() { UserID = 1, RoleID = 1, UserName = "Admin", Name = "Trần Minh Tuấn", Address = "Hà Nội", Phone = "0123654211", Email = "tranminhtuan@gmail.com", Password = "trananhtuan", IsActive = true },
                new User() { UserID = 2, RoleID = 2, UserName = "ThaoPT", Name = "Bùi Phương Thảo", Address = "Hà Nội", Phone = "0123654222", Email = "buiphuongthao@gmail.com", Password = "buiphuongthao", IsActive = true },
                new User() { UserID = 3, RoleID = 3, UserName = "ThanhLT", Name = "Lê Thị Thanh", Address = "Hà Nội", Phone = "0121235897", Email = "lethithanh@gmail.com", Password = "lethithanh", IsActive = true }
              );

            modelBuilder.Entity<Contact>().HasData(
                new Contact() { ContactID = 1, CustomerName = "Trần Lan Anh", Email = "tranlananh@gmail.com", Phone = "0988346655", Content = "Sản phẩm ok", IsActive = true }
            );

        }
    }
}
