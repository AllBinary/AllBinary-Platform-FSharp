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
type NamedAngle =
    inherit Angle
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not NamedAngle.jclinitDone then
            NamedAngle.jclinitDone <- true
            NamedAngle.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (angle: int16, name: string) as this =
        { inherit Angle(angle) }
        then
            this.jctor1(angle, name)
    member this.jctor1(angle: int16, name: string) : unit =
        ()
        this.name <- name
        ()


