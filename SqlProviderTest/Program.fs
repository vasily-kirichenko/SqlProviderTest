open FSharp.Data

let [<Literal>] private connStr = "Data Source=localhost;Initial Catalog=master;Integrated Security=True"
   
type private Query = SqlCommandProvider<"select 1", connStr>
