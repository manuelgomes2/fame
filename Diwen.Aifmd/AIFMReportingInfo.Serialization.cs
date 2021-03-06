//
//  This file is part of Diwen.Aifmd
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2017 John Nordberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Diwen.Aifmd
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    public partial class AIFMReportingInfo
    {
        private static Lazy<XmlSerializer> Serializer = new Lazy<XmlSerializer>(()
            => new XmlSerializer(typeof(AIFMReportingInfo)));

        public static AIFMReportingInfo FromFile(string path)
        {
            using (var file = new FileStream(path, FileMode.Open))
                return (AIFMReportingInfo)Serializer.Value.Deserialize(file);
        }

        public void ToFile(string path)
            => ToFile(this, path);

        private void ToFile(AIFMReportingInfo report, string path)
        {
            using (var file = new FileStream(path, FileMode.Create))
                Serializer.Value.Serialize(file, report);
        }

    }
}