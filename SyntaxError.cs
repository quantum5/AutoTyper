using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTyper {
    class SyntaxError : Exception {
        public SyntaxError(string message) : base(message) {}
    }
}
