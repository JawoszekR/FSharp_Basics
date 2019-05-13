namespace BasicLib
open Newtonsoft.Json

module BasicLibModule =
    let convertToJson str =
        JsonConvert.SerializeObject str
