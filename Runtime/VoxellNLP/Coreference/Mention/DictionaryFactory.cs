//Copyright (C) 2006 Richard J. Northedge
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

//This file is based on the DictionaryFactory.java source file found in the
//original java implementation of Voxell.NLP.  That source file contains the following header:

//Copyright (C) 2003 Thomas Morton
//
//This library is free software; you can redistribute it and/or
//modify it under the terms of the GNU Lesser General Public
//License as published by the Free Software Foundation; either
//version 2.1 of the License, or (at your option) any later version.
//
//This library is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU Lesser General Public License for more details.
//
//You should have received a copy of the GNU Lesser General Public
//License along with this program; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

using System.Configuration;

namespace Voxell.NLP.Coreference.Mention
{
  /// <summary>
  /// Factory class used to get an instance of a dictionary object.
  /// </summary>
  public class DictionaryFactory
  {
    /// <summary>
    /// Returns the default implementation of the Dictionary interface.
    /// </summary>
    public static IDictionary GetDictionary(string searchDirectory)
    {
      if (mDictionary == null)
        mDictionary = new WordnetDictionary(searchDirectory);
      return mDictionary;
    }

    public static IDictionary GetDictionary()
      => GetDictionary(ConfigurationManager.AppSettings["WordnetSearchDirectory"]);

    private static IDictionary mDictionary;
    private DictionaryFactory() {}
  }
}