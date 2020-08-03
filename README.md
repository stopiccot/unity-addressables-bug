1. What happened

Scriptable objects referenced from marked as DontDestroyOnLoad gameObject get unloaded upon scene change.

A bit of explanation:
App has only one non-addressable managed scene - LoaderScene which job is to load MainScene as soon as possible.
On a live app that is done to move all assets to addressables to minimize resource duplication between built-in and addressable resources.
MainScene contains SceneManager game object that is intended to be a singleton that persists between scene loads thus DontDestroyOnLoad() is 
called upon it's start.
For debug purposes SceneManager is spamming it's scriptable object names.
From MainScene you can load either FirstScene that is located "Default Local Group" addressable group
or you can load SecondScene that is located in "Remote Group" addressable group that is loaded from server.
Turns out that loading scene from "Remote Group" leads to scriptable object unloading.
Loading scene from "Default Local Group" works ok.


2. How we can reproduce it using the example you attached

Run the app on any iOS device.
Check that app is correctly spamming "[1111,2222,]" in console
Click "Load Scene 1" button and check that app continues to correctly spam "[1111,2222,]" in console

Restart the app
Click "Load Scene 2" button
App starts to incorrectly spam "[null,null,]" in console
