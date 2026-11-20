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
type DrawVerticalStringUtil =
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] val mutable charHeight : int
    [<DefaultValue(false)>] val mutable offsetY : int
    [<DefaultValue(false)>] val mutable offsetXArray : int[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : DrawVerticalStringUtil
    static member instance with get() : DrawVerticalStringUtil = (DrawVerticalStringUtil.jclinit(); DrawVerticalStringUtil.jcell_instance) and set (jvalue: DrawVerticalStringUtil) = (DrawVerticalStringUtil.jclinit(); DrawVerticalStringUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DrawVerticalStringUtil.jclinitDone then
            DrawVerticalStringUtil.jclinitDone <- true
            DrawVerticalStringUtil.jclinitBody()
    static member private jclinitBody() : unit =
        DrawVerticalStringUtil.jcell_instance <- (new DrawVerticalStringUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_DrawVerticalStringUtil()
    member this.jfields_DrawVerticalStringUtil() : unit =
        this.EMPTY_STRING <- StringUtil.getInstance().EMPTY_STRING
        this.anchor <- Anchor.TOP_LEFT
        this.offsetXArray <- NullUtil.getInstance().NULL_INT_ARRAY
        ()
    
    static member getInstance() : DrawVerticalStringUtil =
        DrawVerticalStringUtil.instance
    
    abstract updateMeasurement : graphics: Graphics * string_: string -> unit
    default this.updateMeasurement(graphics: Graphics, string_: string) : unit =
        let mutable openGLFeatureUtil : OpenGLFeatureUtil = OpenGLFeatureUtil.getInstance()
        let mutable font : Font = graphics.getFont()
        this.charHeight <- font.getHeight()
        this.offsetY <- 0
        if J2MEUtil.isHTML() then
            this.charHeight <- this.charHeight + 1
        elif openGLFeatureUtil.isAnyThreed() then
            this.charHeight <- this.charHeight + 2
            if AndroidUtil.isAndroid() then
                ()
            else
                this.offsetY <- 2 + ((this.charHeight * 2) / 3)
        let mutable size : int = JString.length(string_)
        let mutable aChar : char = '\000'
        let mutable offsetXArray : int[] = (Array.zeroCreate<int> (size))
        let mutable index : int = size - 1
        while index >= 0 do
            aChar <- JString.charAt(string_, index)
            if openGLFeatureUtil.isAnyThreed() then
                offsetXArray.[index] <- font.charWidth(aChar) / 2
            index <- index - 1
        this.offsetXArray <- offsetXArray
    
    abstract paintVerticle : graphics: Graphics * string_: string * x: int * y: int * anchor: int -> unit
    default this.paintVerticle(graphics: Graphics, string_: string, x: int, y: int, anchor: int) : unit =
        let mutable size : int = JString.length(string_)
        let mutable aChar : char = '\000'
        let mutable index : int = size - 1
        while index >= 0 do
            aChar <- JString.charAt(string_, index)
            graphics.drawChar(aChar, (x + this.offsetXArray.[index]), ((y + (this.charHeight * index)) + this.offsetY), anchor)
            index <- index - 1
    
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
    
    abstract drawCenterStrings : graphics: Graphics * stringArray: string[] * maxWidth: int * x: int * y: int -> unit
    default this.drawCenterStrings(graphics: Graphics, stringArray: string[], maxWidth: int, x: int, y: int) : unit =
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
                    this.drawCenterString(graphics, string_, offset, currentLength, x, (y + ((index + ((let jt = extraLines in extraLines <- extraLines + 1; jt))) * this.charHeight)))
                    offset <- offset + currentLength
                    currentLength <- linePortion
                extraLines <- extraLines - 1
            index <- index + 1


