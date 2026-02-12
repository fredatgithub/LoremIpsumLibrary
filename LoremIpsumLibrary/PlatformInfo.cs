namespace LoremIpsumLibrary
{
  public static class PlatformInfo
  {
    public static string GetFramework()
    {
#if NET48
      return ".NET Framework 4.8";
#elif NET8_0
        return ".NET 8";
#else
        return "Unknown";
#endif
    }
  }
}
