using System;

namespace AnnotationProgram
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTime : Attribute
    {
    }
}
