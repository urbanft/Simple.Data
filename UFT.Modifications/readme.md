# UFT.Simple.Data

The three projects included in this folder were modified by UFT to enable upgrading the cc-core project to netstandard2.0. All other projects in the original `Simple.Data` project are not needed and are left out of this folder to reduce maintenance.

If you need a new version, each of the csproj files have the necessary nuget build configs to generate a new NuGet package on build in Visual Studio (2022 as of this writing).

Update the `<Version>` attribute to increment the version.

Once the package is built it can be uploaded to the nuget server. As of this writing, the nuget server is located at `https://nuget.uft-int.com/nuget`
