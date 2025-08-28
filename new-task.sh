#!/usr/bin/env bash
# Скрипт за създаване на нова задача

if [ $# -lt 2 ]; then
  echo "Използване: $0 <chapter> <task-folder>"
  echo "Пример: $0 06 004-SumArray"
  exit 1
fi

chapter=$1
task=$2

# 1. Увери се, че папката Chapter-XX съществува
mkdir -p "Chapter-$chapter"

# 2. Създай конзолен проект вътре
dotnet new console -o "Chapter-$chapter/$task"

# 3. Добави проекта към solution-а
dotnet sln exercises.sln add "Chapter-$chapter/$task/$task.csproj"

echo "✅ Създадена е нова задача: Chapter-$chapter/$task"

