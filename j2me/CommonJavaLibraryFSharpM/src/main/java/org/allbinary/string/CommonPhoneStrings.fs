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
type CommonPhoneStrings =
    [<DefaultValue(false)>] val mutable UP : string
    [<DefaultValue(false)>] val mutable DOWN : string
    [<DefaultValue(false)>] val mutable LEFT : string
    [<DefaultValue(false)>] val mutable RIGHT : string
    [<DefaultValue(false)>] val mutable ZERO : string
    [<DefaultValue(false)>] val mutable ONE : string
    [<DefaultValue(false)>] val mutable TWO : string
    [<DefaultValue(false)>] val mutable THREE : string
    [<DefaultValue(false)>] val mutable FOUR : string
    [<DefaultValue(false)>] val mutable FIVE : string
    [<DefaultValue(false)>] val mutable SIX : string
    [<DefaultValue(false)>] val mutable SEVEN : string
    [<DefaultValue(false)>] val mutable EIGHT : string
    [<DefaultValue(false)>] val mutable NINE : string
    [<DefaultValue(false)>] val mutable POUND : string
    [<DefaultValue(false)>] val mutable STAR : string
    [<DefaultValue(false)>] val mutable FIRE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : CommonPhoneStrings
    static member instance with get() : CommonPhoneStrings = (CommonPhoneStrings.jclinit(); CommonPhoneStrings.jcell_instance) and set (jvalue: CommonPhoneStrings) = (CommonPhoneStrings.jclinit(); CommonPhoneStrings.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommonPhoneStrings.jclinitDone then
            CommonPhoneStrings.jclinitDone <- true
            CommonPhoneStrings.jclinitBody()
    static member private jclinitBody() : unit =
        CommonPhoneStrings.jcell_instance <- (new CommonPhoneStrings())
        ()
    new () as this =
        {  }
        then
            this.jfields_CommonPhoneStrings()
    member this.jfields_CommonPhoneStrings() : unit =
        this.UP <- "UP"
        this.DOWN <- "DOWN"
        this.LEFT <- "LEFT"
        this.RIGHT <- "RIGHT"
        this.ZERO <- "0"
        this.ONE <- "1"
        this.TWO <- "2"
        this.THREE <- "3"
        this.FOUR <- "4"
        this.FIVE <- "5"
        this.SIX <- "6"
        this.SEVEN <- "7"
        this.EIGHT <- "8"
        this.NINE <- "9"
        this.POUND <- "#"
        this.STAR <- "*"
        this.FIRE <- "FIRE"
        ()
    
    static member getInstance() : CommonPhoneStrings =
        CommonPhoneStrings.instance


