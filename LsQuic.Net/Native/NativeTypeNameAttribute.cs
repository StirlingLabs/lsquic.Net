using System;
using JetBrains.Annotations;

namespace StirlingLabs.LsQuic.Native {

  [PublicAPI]
  [AttributeUsage(AttributeTargets.All)]
  internal class NativeTypeNameAttribute : Attribute {

    public string Name;

    public NativeTypeNameAttribute(string name) => Name = name;

  }

}