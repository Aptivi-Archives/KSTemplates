#!/bin/bash

#    Kernel Simulator  Copyright (C) 2018-2021  Aptivi
#
#    This file is part of Kernel Simulator
#
#    Kernel Simulator is free software: you can redistribute it and/or modify
#    it under the terms of the GNU General Public License as published by
#    the Free Software Foundation, either version 3 of the License, or
#    (at your option) any later version.
#
#    Kernel Simulator is distributed in the hope that it will be useful,
#    but WITHOUT ANY WARRANTY; without even the implied warranty of
#    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
#    GNU General Public License for more details.
#
#    You should have received a copy of the GNU General Public License
#    along with this program.  If not, see <https://www.gnu.org/licenses/>.

# Check for dependencies
dotnetpath=`which dotnet`
if [ ! $? == 0 ]; then
	echo dotnet is not found.
	exit 1
fi

# Pack KS templates
echo Packing KS templates...
"$dotnetpath" pack ../../templatepack.sln
if [ ! $? == 0 ]; then
	echo Pack failed.
	exit 1
fi

# Inform success
echo Pack successful.
exit 0
