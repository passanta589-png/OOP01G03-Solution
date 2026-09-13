using System.Security.Principal;

namespace OOP01G03
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            #region 01

            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //    reason :  يتم نسخ البيانات من متغير DeliveryAddress إلى متغير آخر، وعند تعديل النسخة، فإن التغييرات لا تؤثر على المتغير الأصلي.هذا يحدث لأن DeliveryAddress هو نوع قيمة(value type) وليس نوع مرجعي(reference type).عند نسخ قيمة، يتم إنشاء نسخة مستقلة من البيانات، وبالتالي أي تعديل على النسخة لا يغير البيانات الأصلية.   

            //b) What happens when a Customer variable is copied into another variable and the copy is modified ?
            //    reason : عند نسخ متغير Customer إلى متغير آخر، يتم نسخ المرجع إلى نفس الكائن في الذاكرة. لذلك، عند تعديل النسخة، فإن التغييرات تؤثر على المتغير الأصلي أيضًا.هذا يحدث لأن Customer هو نوع مرجعي(reference type)، وعند نسخ المرجع، يتم الإشارة إلى نفس الكائن في الذاكرة، وبالتالي أي تعديل على النسخة يغير البيانات الأصلية أيضًا.
            #endregion

            #region 02

            //a) Identify at least three problems with this design from an encapsulation perspective.
            //1) public fields: The class has public fields, 
            //2)no validation 
            //3)violation of encapsulation

            //b)b) How can private fields and public properties improve this design?
            // 1) protects data
            //2)improves maintainability
            //3) Reduced bugs
            //4)provides flexibility

            #endregion

            #region 03
            //DeliveryAddres address1 = new DeliveryAddres("cairo", "El-tahrir", 12);
            //DeliveryAddres address2 = address1;
            //address2.city = "Alex";
            //address2.buildingNumber = 20;
            //Console.WriteLine($"Address 1: {address1.GetFullAddress()}");
            //Console.WriteLine($"copied & modified Address 2: {address2.GetFullAddress()}"); 
            //Console.WriteLine("proof of struct behavior (value type): when we modify the copy, the original remains unchanged.");

            #endregion

            #region 04
            var shipment = new Shipment();
            // optionally set a description if you expect non-null:
            // shipment.Description = "My shipment";

          //  Console.WriteLine($"tracking code :{TrackingCode}");
            //Console.WriteLine($"description:{shipment.Description}");
            //Console.WriteLine($"weight:{shipment.Weight}1kg");
            //Console.WriteLine($"delivery fee:{shipment.DeliveryFee:c}50"); 
            //Console.WriteLine($"estimated cost:{shipment.estimatedcost:c}");

            #endregion


        }
    }
}


