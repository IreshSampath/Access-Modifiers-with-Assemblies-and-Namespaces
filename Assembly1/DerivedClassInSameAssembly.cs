
namespace Assembly1
{
    internal class DerivedClassInSameAssembly : SampleClass // Derived Class | Same Namespace | Same Asembly
    {
        void FeildsCheck()
        {
            //fieldPrivate = 1; // Error
            fieldPrivateProtected = 1; // work
            fieldInternal = 1; // work
            fieldProtected = 1; // work
            fieldProtectedInternal = 1; // work
            fieldPublic = 1; // work
        }
    }
}
