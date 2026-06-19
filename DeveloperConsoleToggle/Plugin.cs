using BepInEx;
using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;

namespace ForageWizardDeveloperConsole
{
    // Mod metadata
    [BepInPlugin("com.futureflash.foragewizard.devconsole", "Developer Console Toggle", "1.0.0")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            Log.LogInfo("Developer Console Toggle is loaded!");

             // Register custom class (IL2CPP)
            ClassInjector.RegisterTypeInIl2Cpp<ConsoleToggleLogic>();

            // Create a new and empty GameObject that has the code/script
            var modObject = new GameObject("DeveloperConsoleToggle_Object");
            
			// Prevent Unity from destroying the object when a save file/scene loads
			GameObject.DontDestroyOnLoad(modObject);
            
            // Attach the script to the GameObject
            modObject.AddComponent<ConsoleToggleLogic>();
        }
    }

    public class ConsoleToggleLogic : MonoBehaviour
    {
        private void Update()
        {
            // Use the 'BackQuote/Tilde/Back Tick (`)' button located under 'ESC' on your keyboard
			if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                ToggleConsole();
            }
        }

        private void ToggleConsole()
		{
			var allObjects = Resources.FindObjectsOfTypeAll<GameObject>();

			for (int i = 0; i < allObjects.Length; i++) 
			{
				if (allObjects[i].name == "DeveloperConsole") 
				{
					if (allObjects[i].activeSelf == false)
					{
						allObjects[i].SetActive(true);
					}
					
					else 
					{
						allObjects[i].SetActive(false);
					}
				}
			}
		}
    }
}