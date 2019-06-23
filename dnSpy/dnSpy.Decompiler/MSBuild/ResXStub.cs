using System;

namespace dnSpy.Decompiler.MSBuild {
    sealed class ResXDataNode {
        public ResXDataNode(string key, object value) {}
    }

    sealed class ResXResourceWriter : IDisposable {
        public ResXResourceWriter(string filename) {}
        public void AddResource(ResXDataNode node) {}
        public void Dispose() {}
    }
}