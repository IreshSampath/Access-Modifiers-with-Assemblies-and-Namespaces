
namespace Assembly1
{
    public class SampleClass
    {
        private int fieldPrivate; // can access only the same class
        private protected int fieldPrivateProtected; // can access derived classes only in the same assembly
        internal int fieldInternal; // can access only in the same assembly
        protected int fieldProtected; // can access all derived classes in any assembly
        protected internal int fieldProtectedInternal; // can access the same assembly and derived classes in another assembly
        public int fieldPublic; // can access from anywhere

        void FeildsCheck()
        {
            fieldPrivate = 1; // work
            fieldPrivateProtected = 1; // work
            fieldInternal = 1; // work
            fieldProtected = 1; // work
            fieldProtectedInternal = 1; // work
            fieldPublic = 1; // work
        }
    }

    namespace Nested // Nested Class | Different Namespace | Same Asembly 
    {
        class SampleClass2Nested
        {
            SampleClass sampleClass = new SampleClass();

            void FeildsCheck()
            {
                //sampleClass.fieldPrivate = 1; // Error
                //sampleClass.fieldPrivateProtected = 1; // Error
                sampleClass.fieldInternal = 1; // work
                //sampleClass.fieldProtected = 1; // Error
                sampleClass.fieldProtectedInternal = 1; // work
                sampleClass.fieldPublic = 1; // work
            }
        }
    }
}
