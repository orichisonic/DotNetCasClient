﻿/*
 * Licensed to Jasig under one or more contributor license
 * agreements. See the NOTICE file distributed with this work
 * for additional information regarding copyright ownership.
 * Jasig licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a
 * copy of the License at:
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

#pragma warning disable 1591

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using DotNetCasClient.Validation.Schema.XmlDsig;

namespace DotNetCasClient.Validation.Schema.Xenc
{
    [XmlInclude(typeof(EncryptedKeyType))]
    [XmlInclude(typeof(EncryptedDataType))]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="http://www.w3.org/2001/04/xmlenc#")]
    public abstract class EncryptedType {
        public EncryptionMethodType EncryptionMethod
        {
            get;
            set;
        }

        [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public KeyInfoType KeyInfo
        {
            get;
            set;
        }

        public CipherDataType CipherData
        {
            get;
            set;
        }

        public EncryptionPropertiesType EncryptionProperties
        {
            get;
            set;
        }

        [XmlAttribute(DataType="ID")]
        public string Id
        {
            get;
            set;
        }

        [XmlAttribute(DataType="anyURI")]
        public string Type
        {
            get;
            set;
        }

        [XmlAttribute]
        public string MimeType
        {
            get;
            set;
        }

        [XmlAttribute(DataType="anyURI")]
        public string Encoding
        {
            get;
            set;
        }
    }
}

#pragma warning restore 1591