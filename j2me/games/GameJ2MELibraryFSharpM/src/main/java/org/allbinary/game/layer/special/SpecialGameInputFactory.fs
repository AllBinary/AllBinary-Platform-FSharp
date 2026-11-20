namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
 *  
 * By agreeing to this license you and any business entity you represent are 
 * legally bound to the AllBinary Open License Version 1 legal agreement. 
 *  
 * You may obtain the AllBinary Open License Version 1 legal agreement from 
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository. 
 *  
 * Created By: Travis Berthelot 
 *   
 *)

[<AllowNullLiteral>]
type SpecialGameInputFactory =
    [<DefaultValue(false)>] static val mutable private jcell_NO_SPECIAL_GAME_INPUT : SpecialGameInput
    static member NO_SPECIAL_GAME_INPUT with get() : SpecialGameInput = (SpecialGameInputFactory.jclinit(); SpecialGameInputFactory.jcell_NO_SPECIAL_GAME_INPUT) and set (jvalue: SpecialGameInput) = (SpecialGameInputFactory.jclinit(); SpecialGameInputFactory.jcell_NO_SPECIAL_GAME_INPUT <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpecialGameInputFactory.jclinitDone then
            SpecialGameInputFactory.jclinitDone <- true
            SpecialGameInputFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SpecialGameInputFactory.jcell_NO_SPECIAL_GAME_INPUT <- (new SpecialGameInput())
        ()
    new () =
        {  }


