namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
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
type CanvasUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CanvasUtil.jclinitDone then
            CanvasUtil.jclinitDone <- true
            CanvasUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member getKeyName(key: int) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable commonPhoneStrings : CommonPhoneStrings = CommonPhoneStrings.getInstance()
        if key = Canvas.UP then
            jret <- commonPhoneStrings.UP
            jflow <- 1
        elif key = Canvas.DOWN then
            jret <- commonPhoneStrings.DOWN
            jflow <- 1
        elif key = Canvas.RIGHT then
            jret <- commonPhoneStrings.RIGHT
            jflow <- 1
        elif key = Canvas.LEFT then
            jret <- commonPhoneStrings.LEFT
            jflow <- 1
        elif key = Canvas.FIRE then
            jret <- commonPhoneStrings.FIRE
            jflow <- 1
        if jflow = 0 then
            jret <- "UNKNOWN KEY"
            jflow <- 1
        jret


