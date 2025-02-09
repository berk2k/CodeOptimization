using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionSpan.Console
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net80)]

    public class BenchMarks
    {
        private readonly string[] logLines;

        public BenchMarks()
        {
            logLines = File.ReadLines("request_logs.txt").ToArray();
        }

        [Benchmark]
        public List<LogModel> ProcessLogs_Span()
        {
            return LogParser.ProcessLogs_Span(logLines);
        }

        [Benchmark]
        public List<LogModel> ProcessLogs_String()
        {
            return LogParser.ProcessLogs_String(logLines);
        }


        [Benchmark]
        public List<LogModel> ProcessLogs_Split()
        {
            return LogParser.ProcessLogs_Split(logLines);
        }

        [Benchmark]
        public List<LogModel> ProcessLogs_Regex()
        {
            return LogParser.ProcessLogs_Regex(logLines);
        }

        [Benchmark]
        public List<LogModel> ProcessLogs_CompiledRegex()
        {
            return LogParser.ProcessLogs_CompiledRegex(logLines);
        }
    }
}
