# Antlr4 CodeGenerator tool

[![License](https://img.shields.io/badge/license-MIT-blue.svg?logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAAHYcAAB2HAY%2Fl8WUAAAAZdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuMTCtCgrAAAADB0lEQVR4XtWagXETMRREUwIlUAIlUAodQAl0AJ1AB9BB6AA6gA6MduKbkX%2BevKecNk525jHO3l%2Fp686xlJC70%2Bl0C942vjV%2Bn9FreVQbBc0wWujfRpW8Z78JaIb53hhJ1ygTA80w9PQ36duBMjHQHPCuoQZfutSjeqU1PAJN4E3j2pN7aVKv6pnWcgGawNfGa5N6prVcgGZBn8yvVXZXQbOgPXokXaPMNZwoc41D%2FaHZ8b7hpBrKjnCizIjD%2FaHZ8aPR6%2BeZXqqh7Agnyow43B%2BaZz40qnQ36a6rlsYgnChDLOkPzTN1z%2B9PafU0N3OAcaIMsaQ%2FNBufG1X9JyrtDMr0Y4xwokxlWX%2BPjAYdemhPrWeDvYcPJ8r0LO3v4oszNfivQQuTp2u9qJGKE2V6lvZ38UVj9q3t3oqEE2U2lvfXF4t6qPjTqDUV1fRyhw8nymws768vfOr2NtqOqFY4UUZE%2BusL6VDRX7%2FGzOHDiTIi0t9WMPsUKzNPx4kysf62gmuHir3sPXw4USbWny485ZOc2PsJ7VTro%2F3pwp5DxV7qHq2xa41TrY%2F2J7PfJkaHir3UwwdtU061PtqfTP0CUaYm2v3LxCtoDI2lMWk8p1of7Y8K0jhRJgaaYZwoE0P%2FpFUndZqtP6T4BE2zC5qtP6T4BE2zC5qtPyRN8OvhZUQae3ZBtT7anyb49PA6Ivp5wKnWR%2FvbJkncZXr6wokysf62CXRCWjmJxhqd2JwoE%2BuvTqS37JGJlB39GLzhRJmN5f31gz8XTpSJgWYYJ8rEQDOME2VioBnGiTIx0AzjRJkYaIZxokwMNMM4USYGmmGcKBMDzTBOlImBZhgnysRAM4wTZWKgGcaJMjHQDONEmRhohnGiTAw0wzhRJgaaYZwoEwPNME6UiYFmGCfKxEAzjBNlYqAZxokyMdAMoL%2FO%2BNi4bzjpT1e%2BNFb8V7gFzUXMLHqk%2BM1A8wArFj1S5GagOUly0SMtuxloTnJrUU%2B7QXOSW4t62g2ak9xa1NNu0Jzk1qKednK6%2Bw9roIB8keT%2F3QAAAABJRU5ErkJggg%3D%3D)](LICENSE.md)

[![Latest Release](https://img.shields.io/nuget/v/Antlr4CodeGenerator.Tool?logo=nuget&label=release)](https://www.nuget.org/packages/Antlr4CodeGenerator.Tool)
[![Latest pre Release](https://img.shields.io/nuget/vpre/Antlr4CodeGenerator.Tool?logo=nuget)](https://www.nuget.org/packages/Antlr4CodeGenerator.Tool)

[![Build Status master](https://dev.azure.com/pbruch0060/pbruch/_apis/build/status/ptr1120.Antlr4.CodeGenerator.Tool?branchName=master)](https://dev.azure.com/pbruch0060/pbruch/_build/latest?definitionId=1&branchName=master)
[![Build Status develop](https://dev.azure.com/pbruch0060/pbruch/_apis/build/status/ptr1120.Antlr4.CodeGenerator.Tool?branchName=develop)](https://dev.azure.com/pbruch0060/pbruch/_build/latest?definitionId=1&branchName=develop)



Just a commandline wrapper around the ANTLR (Java) tool ([Version 4.12.0](https://www.antlr.org/download/antlr-4.12.0-complete.jar)) for generating grammar artifacts.

The ANTLR (Java) tool is *bundled*, so no need to download it.

## Dependencies

* Java runtime

## Installation

* Install as dotnet **global tool**:

  ```shell
  dotnet tool install --global Antlr4CodeGenerator.Tool
  ```

* Install as dotnet **local tool** (inside a dotnet project where you want to generate language artifacts):
    * See also [sample project](samples/Calculator)
    * Enable local dotnet tools for your project by the following command on solution file directory level:

    ```shell
    dotnet new tool-manifest
    ```

    * Install as local tool to your project:

    ```shell
    dotnet tool install Antlr4CodeGenerator.Tool
    ```

## Usage

This tool only proxies the arguments to the ANTLR (Java) tool. (See also [ANTLR (Java) tool arguments documentation](https://github.com/antlr/antlr4/blob/master/doc/tool-options.md))

* **global tool**:

    ```shell
    dotnet antlr4-tool -Dlanguage=CSharp MyGrammar.g4
    ```

* **local tool** via MsBuild target:
    * See also [sample project](samples/Calculator)

    ```xml
    <Target Name="GenerateAntlrArtifacts" BeforeTargets="BeforeResolveReferences">
      <PropertyGroup>
        <_GrammarFile>$(ProjectDir)calculator.g4</_GrammarFile>
        <_Generated>$(ProjectDir).generated\</_Generated>
        <_Namespace>MyCalculator</_Namespace>
      </PropertyGroup>
       <Exec Command="dotnet antlr4-tool -Dlanguage=CSharp  -o &quot;$(_Generated)&quot; -visitor -listener -package $(_Namespace) &quot;$(_GrammarFile)&quot;" />
    </Target>
    ```
