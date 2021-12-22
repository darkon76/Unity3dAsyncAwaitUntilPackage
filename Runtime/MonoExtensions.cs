using System.Threading.Tasks;
using UnityEngine;

public static class MonoExtensions
{
    public static void StartCoroutine(this MonoBehaviour monoBehaviour, Task task)
    {
        monoBehaviour.StartCoroutine(task.AsIEnumerator());
    }
}
