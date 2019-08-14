module HelloWorldLibrary
open Newtonsoft.Json

let convertToJson str =
    JsonConvert.SerializeObject str
