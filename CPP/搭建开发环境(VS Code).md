之所以写这个，是因为官方文档是英文的...

## 1. 安装C++编译器

- 安装[MinGW-W64](http://www.mingw-w64.org/doku.php/start) 
- 添加系统环境变量

## 2. 安装C/C++扩展

- 打开VS Code
- 使用快捷方式“Ctrl+Shift+X”打开扩展视图
- 搜素C++
- 安装C/C++扩展

## 3. 配置智能感知

- 使用快捷组合键“Ctrl+Shift+P”打开命令选项板
- 选择“C/Cpp: Edit Configurations...”，打开“c_cpp_properties.json”配置文档

    {
	    "name": "Win32",
	    "includePath": [
	        "${workspaceFolder}"
	    ],
	    "defines": [
	        "_DEBUG",
	        "UNICODE"
	    ],
	    "compilerPath": "C:\\mingw-w64\\bin\\gcc.exe",
	    "intelliSenseMode": "clang-x64",
	    "browse": {
	        "path": [
	            "${workspaceFolder}"
	        ],
	        "limitSymbolsToIncludedHeaders": true,
	        "databaseFilename": ""
	    }
	}

## 4. 构建(build)

- 使用快捷组合键“Ctrl+Shift+P”打开命令选项板
- 选择“Tasks: Configure Task” -> “Create tasks.json file from templates” -> “Others”

    {
	    "version": "2.0.0",
	    "tasks": [
	        {
	            "label": "build hello world",
	            "type": "shell",
	            "command": "g++",
	            "args": [
	                "-g", "helloworld.cpp" // workfolder or full path
	            ],
	            "group": {
	                "kind": "build",
	                "isDefault": true
	            }
	        }
	    ]
	}

- 现在可以使用“Ctrl+Shift+B”来构建程序了

## 5. 调试(Debug)

- 从侧边栏的Debug图标进入Debug视图
- 点击Configure图标
- 选择C++ (GDB/LLDB)

    {
	    "version": "0.2.0",
	    "configurations": [
	        {
	            "name": "(gdb) Launch",
	            "type": "cppdbg",
	            "request": "launch",
	            "program": "${workspaceFolder}/a.exe", // workfolder or full path
	            "args": [],
	            "stopAtEntry": false,
	            "cwd": "${workspaceFolder}", // workfolder or full path
	            "environment": [],
	            "externalConsole": true,
	            "MIMode": "gdb",
	            "miDebuggerPath": "C:\\mingw\\bin\\gdb.exe",
	            "setupCommands": [
	                {
	                    "description": "Enable pretty-printing for gdb",
	                    "text": "-enable-pretty-printing",
	                    "ignoreFailures": true
	                }
	            ],
	            "preLaunchTask": "build hello world"
	        }
	    ]
	}