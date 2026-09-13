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
        }
    }
}

