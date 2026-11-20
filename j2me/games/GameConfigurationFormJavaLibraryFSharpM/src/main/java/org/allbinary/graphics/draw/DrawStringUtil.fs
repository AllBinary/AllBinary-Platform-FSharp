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
type DrawStringUtil =
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jcell_instance : DrawStringUtil
    static member instance with get() : DrawStringUtil = (DrawStringUtil.jclinit(); DrawStringUtil.jcell_instance) and set (jvalue: DrawStringUtil) = (DrawStringUtil.jclinit(); DrawStringUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DrawStringUtil.jclinitDone then
            DrawStringUtil.jclinitDone <- true
            DrawStringUtil.jclinitBody()
    static member private jclinitBody() : unit =
        DrawStringUtil.jcell_instance <- (new DrawStringUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_DrawStringUtil()
    member this.jfields_DrawStringUtil() : unit =
        this.EMPTY_STRING <- StringUtil.getInstance().EMPTY_STRING
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    static member getInstance() : DrawStringUtil =
        DrawStringUtil.instance
    
    abstract drawCenterString : graphics: Graphics * string_: string * offset: int * length: int * x: int * y: int -> unit
    default this.drawCenterString(graphics: Graphics, string_: string, offset: int, length: int, x: int, y: int) : unit =
        let mutable width : int = (graphics.getFont().substringWidth(string_, offset, length) >>> 1)
        try
            graphics.drawSubstring(string_, offset, length, (x - width), y, this.anchor)
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                PreLogUtil.put((new StringMaker()).append("Exception: stringLength: ").appendint(JString.length(string_)).append(" offset: ").appendint(offset).append(" currentLength: ").appendint(length).ToString(), this, "drawCenterString")
            | _ -> reraise ()
    
    abstract drawCenterStrings : graphics: Graphics * stringArray: string[] * maxWidth: int * charHeight: int * x: int * y: int -> unit
    default this.drawCenterStrings(graphics: Graphics, stringArray: string[], maxWidth: int, charHeight: int, x: int, y: int) : unit =
        let mutable extraLines : int = 0
        let mutable index : int = 0
        while index < stringArray.Length do
            let mutable string_ : string = stringArray.[index]
            if not (JR.sameString(string_, this.EMPTY_STRING)) then
                let mutable width : int = graphics.getFont().stringWidth(string_)
                let mutable minTotalLines : int = 1
                if width > maxWidth then
                    minTotalLines <- (width / maxWidth) + 1
                let mutable linePortion : int = JString.length(string_) / minTotalLines
                let mutable offset : int = 0
                let mutable currentLength : int = linePortion
                let mutable size : int = JString.length(string_)
                while offset < size do
                    if (offset + currentLength) > size then
                        currentLength <- size - offset
                    if (offset + currentLength) <> size then
                        while (currentLength > 0) && (JString.charAt(stringArray.[index], (offset + currentLength)) <> ' ') do
                            currentLength <- currentLength - 1
                        if currentLength <= 4 then
                            currentLength <- linePortion
                    this.drawCenterString(graphics, string_, offset, currentLength, x, (y + ((index + ((let jt = extraLines in extraLines <- extraLines + 1; jt))) * charHeight)))
                    offset <- offset + currentLength
                    currentLength <- linePortion
                extraLines <- extraLines - 1
            index <- index + 1


