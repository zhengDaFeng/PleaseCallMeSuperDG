之所以写这个中文档，是因为官方文档是英文的，并且有些地方没说明白...（可能是我太小白了...）

## 1. 安装C++编译器

- 安装[MinGW-W64](http://www.mingw-w64.org/doku.php/start) (注意：Architecture选择x86_64版本)
- 添加系统环境变量（注意：除了安装目录下的bin文件夹路径添加到Path，还可以新建系统变量CPP_INCLUDE变量，并将其下的include文件夹添加进这个我们新建的系统变量）

## 2. 安装C/C++扩展

- 打开VS Code
- 打开扩展视图(Ctrl+Shift+X)
- 搜索C++
- 安装C/C++扩展
- 重启软件

## 3. 配置智能感知

- 打开命令选项板(Ctrl+Shift+P)
- 选择**C/Cpp: Edit Configurations...**，打开*c_cpp_properties.json*配置文档

~~~json
    {
	    "name": "Win32",
	    "includePath": [
	        "${workspaceFolder}"
	        // 可以将include路径添加到这个地方
	    ],
	    "defines": [
	        "_DEBUG",
	        "UNICODE"
	    ],
	    "compilerPath": "C:\\mingw-w64\\bin\\gcc.exe", // 指向gcc编译器
	    "intelliSenseMode": "clang-x64",
	    "browse": {
	        "path": [
	            "${workspaceFolder}"
	        ],
	        "limitSymbolsToIncludedHeaders": true,
	        "databaseFilename": ""
	    }
	}
~~~

## 4. 构建(build)

- 打开命令选项板(Ctrl+Shift+P)
- 选择**Tasks: Configure Task** -> **Create tasks.json file from templates** -> **Others**

~~~json
    {
	    "version": "2.0.0",
	    "tasks": [
	        {
	            "label": "build hello world", // 标签名，根据实际需要
	            "type": "shell",
	            "command": "g++",
	            "args": [
	                "-g", "helloworld.cpp" // 指向需要构建的文件，根据实际需要
	            ],
	            "group": {
	                "kind": "build",
	                "isDefault": true
	            }
	        }
	    ]
	}
~~~

- 现在可以使用“Ctrl+Shift+B”来构建程序了

## 5. 调试(Debug)

- 从侧边栏的Debug图标进入Debug视图
- 点击Configure图标
- 选择C++ (GDB/LLDB)

~~~json
    {
	    "version": "0.2.0",
	    "configurations": [
	        {
	            "name": "(gdb) Launch",
	            "type": "cppdbg",
	            "request": "launch",
	            "program": "${workspaceFolder}/a.exe", // 指向需要运行的程序
	            "args": [],
	            "stopAtEntry": false,
	            "cwd": "${workspaceFolder}",
	            "environment": [],
	            "externalConsole": true,
	            "MIMode": "gdb",
	            "miDebuggerPath": "C:\\mingw\\bin\\gdb.exe", // 指向调试器
	            "setupCommands": [
	                {
	                    "description": "Enable pretty-printing for gdb",
	                    "text": "-enable-pretty-printing",
	                    "ignoreFailures": true
	                }
	            ],
	            "preLaunchTask": "build hello world" // 指向构建任务的标签名
	        }
	    ]
	}
~~~
