//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

using Microsoft.Identity.Core;
using Microsoft.IdentityModel.Clients.ActiveDirectory.Internal;

namespace Microsoft.IdentityModel.Clients.ActiveDirectory
{

    /// <summary>
    /// Credential used for integrated authentication on domain-joined machines.
    /// </summary>
    public class UserCredential
    {
        internal IntegratedWindowsAuthInput IWAInput  { get;} 

        /// <summary>
        /// Constructor to create user credential. Using this constructor would imply integrated authentication with logged in user
        /// and it can only be used in domain joined scenarios.
        /// </summary>
        public UserCredential()
        {
            IWAInput = new IntegratedWindowsAuthInput();
        }

        /// <summary>
        /// Constructor to create credential with username
        /// </summary>
        /// <param name="userName">Identifier of the user application requests token on behalf.</param>
        public UserCredential(string userName)
        {
            IWAInput = new IntegratedWindowsAuthInput(userName);
        }

        /// <summary>
        /// Gets identifier of the user.
        /// </summary>
        public string UserName
        {
            get { return IWAInput.UserName; }
        }
    }
}