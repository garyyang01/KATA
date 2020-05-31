using JetBrains.Annotations;

namespace Kata.Extension
{
    public static class CustomSourceTemplate
    {
        [JetBrains.Annotations.SourceTemplateAttribute]
        [Macro(Target = "expected", Editable = 1)]
        public static void ae<T>(this T source)
        {
            /*$ Assert.AreEqual( $expected$ , source);*/
        }

        [JetBrains.Annotations.SourceTemplateAttribute]
        public static void abs<T>(this T source)
        {
            /*$ Math.Abs(source)*/
        }
    }
}