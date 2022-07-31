# Enumerable Extensions
Extension class for easily working with collections and random elements

[![openupm](https://img.shields.io/npm/v/com.sandrofigo.enumerable-extensions-unity3d?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.sandrofigo.enumerable-extensions-unity3d/)

## Installation
There are multiple ways to install this package into your project:
- Add it to your project through [OpenUPM](https://openupm.com/packages/com.sandrofigo.enumerable-extensions-unity3d/) (recommended)
- Add the package to the Unity package manager using the HTTPS URL of this repository (recommended)
- Download the whole repository as a .zip and place the contents into a subfolder in your assets folder
- Fork the repository and add it as a submodule in git

## Usage
```csharp
using EnumerableExtensions;
using UnityEngine;

public class Foo : MonoBehaviour
{
    public void Bar()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        
        Debug.Log(list.Random());
        // Output: either 1, 2 or 3
        
        foreach(int i in list.RandomOnce())
            Debug.Log(i);
        // Output: 1, 2 and 3 in random order
        
        Debug.Log(list.IsEmpty());
        // Output: false
    }
}
```

## Collaboration
Support this project with a ⭐️, report an issue or if you feel adventurous and would like to extend the functionality open a pull request.
