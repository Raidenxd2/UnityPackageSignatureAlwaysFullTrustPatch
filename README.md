# UnityPackageSignatureAlwaysFullTrustPatch

Patches UnityEditor.PackageManager.UI.Internal.UpmPackageVersion.trustAndSignature to always return TrustAndSignature.FullTrustUnitySignature \
Requires Harmony to be in your project \
 \
The reason the assembly is called DynamicProxyGenAssembly2 is because it has access to all of the internal methods and classes \
 \
Minimum Unity Version: 6000.3.0a1 \
Tested in Unity 6000.3.0f1 (5dac2ad68189)

<img width="1447" height="877" alt="image" src="https://github.com/user-attachments/assets/49a335a0-ec8f-483c-ac74-0f7bcfde7696" />
