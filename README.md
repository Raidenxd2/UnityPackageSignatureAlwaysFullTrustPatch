# UnityPackageSignatureAlwaysFullTrustPatch

Patches UnityEditor.PackageManager.UI.Internal.UpmPackageVersion.trustAndSignature to always return TrustAndSignature.FullTrustUnitySignature \
 \
Requires Harmony to be in your project \
 \
The reason the assembly is called DynamicProxyGenAssembly2 is because it has access to all of the internal methods and classes
 \
Minimum Unity Version: 6000.3.0a1 \