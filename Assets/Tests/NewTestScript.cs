using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            Assert.AreEqual(true, true);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            int i = 0;
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            if (i < 5)
            {
                Assert.AreEqual(true, true);
                i++;
                yield return null;
            }
        }
    }
}
