﻿// Copyright 2015 SpectralCoding
// 
// This file is part of IncreBuild.
// 
// IncreBuild is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// IncreBuild is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with IncreBuild.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IncreBuild {
	class Program {
		[STAThread]
		static void Main(string[] args) {
			Dictionary<ArgumentType, string> ArgList = ArgumentParser.ParseArguments(args);
			if (ArgList.Count == 0 || ArgList.ContainsKey(ArgumentType.Options)) {
				// No Arguments or the "/options" argument exists.
				// Don't run anything, display the configuration interface.
				Application OptionsApp = new Application();
				OptionsApp.Run(new OptionsWindow());
			} else {
				Console.WriteLine("[[ PLACEHOLDER FOR APPLICATION LOGIC ]]");
			}
			//Console.ReadLine();
		}
	}
}
