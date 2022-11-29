using Assembly1;

namespace Assembly2
{
    internal class OtherClassInAssembly2 // Derived Class | Different Namespace | Defferent Asembly
    {
        SampleClass sampleClass = new SampleClass();

        void FeildsCheck()
        {
            //sampleClass.fieldPrivate = 1; // Error
            //sampleClass.fieldPrivateProtected = 1; // Error
            //sampleClass.fieldInternal = 1; // Error
            //sampleClass.fieldProtected = 1; // Error
            //sampleClass.fieldProtectedInternal = 1; // Error
            sampleClass.fieldPublic = 1; // work
        }
    }
}
