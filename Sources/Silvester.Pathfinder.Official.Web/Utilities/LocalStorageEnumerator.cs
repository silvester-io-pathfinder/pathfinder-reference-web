using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Utilities
{
    public class StorageKeyEnumerator
    {
        private ILocalStorageService LocalStorage;

        internal StorageKeyEnumerator(ILocalStorageService localStorage)
        {
            LocalStorage = localStorage;
        }

        public async IAsyncEnumerable<string> GetKeysAsync([EnumeratorCancellation] CancellationToken cancellationToken)
        {
            for(int i = 0; i < await LocalStorage.LengthAsync(cancellationToken); i ++)
            {
                string key = await LocalStorage.KeyAsync(i, cancellationToken);
                yield return key;
            }
        }
    }
}
