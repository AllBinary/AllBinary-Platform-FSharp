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
type ArtificialIntelligenceFactory =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ArtificialIntelligenceFactory.jclinitDone then
            ArtificialIntelligenceFactory.jclinitDone <- true
            ArtificialIntelligenceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract getInstance : anyType: obj -> ArtificialIntelligence
    default this.getInstance(anyType: obj) : ArtificialIntelligence =
        raise ((new JRuntimeException()))
    interface ArtificialIntelligenceFactoryInterface with
        member this.getInstance(jp0: obj) : ArtificialIntelligence = this.getInstance(jp0)


