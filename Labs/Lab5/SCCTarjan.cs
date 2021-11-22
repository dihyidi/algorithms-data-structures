using System.Collections.Generic;

namespace lab_5
{
    public class SccTarjan
    {
      private readonly List<int>[] _graph;
      private readonly bool[] _visited;
      private readonly Stack<int> _stack;
      private int _time;
      private readonly int[] _lowLink;
      private readonly List<List<int>> _components;

      public SccTarjan(List<int>[] graph)
      {
        var len = graph.Length;
        _graph = graph;
        _visited = new bool[len];
        _stack = new Stack<int>();
        _time = 0;
        _lowLink = new int[len];
        _components = new List<List<int>>();
      }

      public List<List<int>> Scc()
      {
        for (var i = 0; i < _graph.Length; i++)
        {
          if (!_visited[i])
            Dfs(i);

        }
        return _components;
      }
      

      private void Dfs(int i)
      {
        _lowLink[i] = _time++;
        _visited[i] = true;
        _stack.Push(i);

        var isComponentRoot = true;

        foreach (var x in _graph[i])
        {
          if(!_visited[x])
            Dfs(x);
          if (_lowLink[i] <= _lowLink[x]) continue;
          _lowLink[i] = _lowLink[x];
          isComponentRoot = false;
        }

        if (!isComponentRoot) return;
        {
          var component = new List<int>();
          int x;
          do
          {
            x = _stack.Pop();
            component.Add(x);
            _lowLink[x] = int.MaxValue;
          }
          while (x != i);
          _components.Add(component);
        }
      }
    }
}