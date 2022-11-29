using Assembly1;

namespace Assembly2
{
    internal class DerivedClassInAssembly2 : SampleClass // Outside the Class | Different Namespace | Defferent Asembly
    {
        void FeildsCheck()
        {
            //fieldPrivate = 1; // Error
            //fieldPrivateProtected = 1; // Error
            //fieldInternal = 1; // Error
            fieldProtected = 1; // work
            fieldProtectedInternal = 1; // work
            fieldPublic = 1; // work
        }
    }
}
