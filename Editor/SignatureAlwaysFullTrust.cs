#if UNITY_EDITOR
using HarmonyLib;
using System.Reflection;
using UnityEditor;
using UnityEditor.PackageManager.UI.Internal;

[InitializeOnLoad]
public class SignatureAlwaysFullTrust : Editor
{
    public static Harmony harmony;

    static SignatureAlwaysFullTrust()
    {
        if (harmony == null)
        {
            harmony = new("SignatureAlwaysFullTrust");
        }

        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}

[HarmonyPatch(typeof(UpmPackageVersion))]
[HarmonyPatch("trustAndSignature", MethodType.Getter)]
public class SignatureAlwaysFullTrustPatch
{
    static void Postfix(ref TrustAndSignature __result)
    {
        __result = TrustAndSignature.FullTrustUnitySignature;
    }
}
#endif