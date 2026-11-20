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
type InputMappingHelpPaintable =
    inherit HelpPaintable
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable commonSeps : CommonSeps
    [<DefaultValue(false)>] val mutable stringUtil : StringUtil
    [<DefaultValue(false)>] val mutable basicColorFactory : BasicColorFactory
    [<DefaultValue(false)>] val mutable NONE : GameKey
    [<DefaultValue(false)>] val mutable EMPTY_STRING : string
    [<DefaultValue(false)>] val mutable gameInputMappingArray : GameInputMapping[]
    [<DefaultValue(false)>] val mutable keyMappingArray : BasicArrayList[]
    [<DefaultValue(false)>] val mutable actionBasicColor : BasicColor[]
    [<DefaultValue(false)>] val mutable inputBasicColorArray : BasicColor[][]
    [<DefaultValue(false)>] val mutable selectedBasicColor : BasicColor
    [<DefaultValue(false)>] val mutable updateMyFontProperties : UpdateMyFontProperties
    static member AND : string = " and "
    static member SEP : string = ", "
    static member MORE_THAN_TWO_IN_LIST_AND : string = ", and "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputMappingHelpPaintable.jclinitDone then
            InputMappingHelpPaintable.jclinitDone <- true
            InputMappingHelpPaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_InputMappingHelpPaintable() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        this.commonSeps <- CommonSeps.getInstance()
        this.stringUtil <- StringUtil.getInstance()
        this.basicColorFactory <- BasicColorFactory.getInstance()
        this.NONE <- GameKeyFactory.getInstance().NONE
        this.EMPTY_STRING <- StringUtil.getInstance().EMPTY_STRING
        this.keyMappingArray <- (Array.zeroCreate<BasicArrayList> (0))
        this.actionBasicColor <- BasicColorUtil.getInstance().ZERO_ARRAY
        this.inputBasicColorArray <- (JR.newArray2<BasicColor>(0, 0))
        this.updateMyFontProperties <- (new UpdateMyFontProperties())
        ()
    
    new (gameInputMappingArray: GameInputMapping[], backgroundBasicColor: BasicColor, basicColor: BasicColor) as this =
        { inherit HelpPaintable("Input Mapping", backgroundBasicColor, basicColor) }
        then
            this.jfields_InputMappingHelpPaintable()
            this.jctor1(gameInputMappingArray, backgroundBasicColor, basicColor)
    member this.jctor1(gameInputMappingArray: GameInputMapping[], backgroundBasicColor: BasicColor, basicColor: BasicColor) : unit =
        ()
        this.gameInputMappingArray <- gameInputMappingArray
        this.update(this.NONE, this.NONE)
        if ((JR.same(backgroundBasicColor, this.basicColorFactory.WHITE))) || ((JR.same(basicColor, this.basicColorFactory.WHITE))) then
            this.selectedBasicColor <- this.basicColorFactory.RED
        else
            this.selectedBasicColor <- this.basicColorFactory.WHITE
        ()
    
    override this.updateMeasurement(graphics: Graphics) : unit =
        let mutable font : Font = graphics.getFont()
        let mutable updateMyFontProperties : UpdateMyFontProperties = (new UpdateMyFontProperties())
        updateMyFontProperties.charHeight <- font.getHeight()
        let mutable stringMaker : StringMaker = (new StringMaker())
        let mutable inputInfo : string[] = this.inputInfo
        let mutable size : int = inputInfo.Length
        updateMyFontProperties.actionStringArray <- (Array.zeroCreate<string> (size))
        updateMyFontProperties.keymappingBeginWidthArray <- (Array.zeroCreate<int> (size))
        updateMyFontProperties.actionStringDeltaXArray <- (Array.zeroCreate<int> (size))
        updateMyFontProperties.inputDeltaXArray <- (JR.newArray2<int>(size, 0))
        updateMyFontProperties.sepArray <- (JR.newArray2<string>(size, 0))
        updateMyFontProperties.sepWidthArray <- (JR.newArray2<int>(size, 0))
        let mutable list_ : BasicArrayList = null
        let mutable keyMappings : string = null
        let mutable actionString : string = null
        let mutable input : Input = null
        let mutable size2 : int = 0
        let mutable index : int = 0
        while index < size do
            list_ <- this.keyMappingArray.[index]
            keyMappings <- this.get(list_)
            ignore (stringMaker.delete(0, stringMaker.length()))
            actionString <- stringMaker.append(inputInfo.[index]).append(this.commonSeps.COLON).append(this.commonSeps.SPACE).append(this.commonSeps.SPACE).ToString()
            updateMyFontProperties.actionStringArray.[index] <- actionString
            ignore (stringMaker.delete(0, stringMaker.length()))
            updateMyFontProperties.keymappingBeginWidthArray.[index] <- (font.stringWidth(stringMaker.append(updateMyFontProperties.actionStringArray.[index]).append(keyMappings).ToString()) >>> 1)
            updateMyFontProperties.actionStringDeltaXArray.[index] <- font.stringWidth(actionString)
            size2 <- list_.size()
            updateMyFontProperties.inputDeltaXArray.[index] <- (Array.zeroCreate<int> (size2))
            updateMyFontProperties.sepArray.[index] <- (Array.zeroCreate<string> (size2))
            updateMyFontProperties.sepWidthArray.[index] <- (Array.zeroCreate<int> (size2))
            let mutable index2 : int = 0
            while index2 < size2 do
                input <- (box (list_.objectArray.[index2]) :?> Input)
                updateMyFontProperties.inputDeltaXArray.[index].[index2] <- font.stringWidth(input.getName())
                updateMyFontProperties.sepArray.[index].[index2] <- this.EMPTY_STRING
                if (index2 + 1) < list_.size() then
                    if list_.size() = 2 then
                        updateMyFontProperties.sepArray.[index].[index2] <- InputMappingHelpPaintable.AND
                    else
                        if (index2 + 2) = list_.size() then
                            updateMyFontProperties.sepArray.[index].[index2] <- InputMappingHelpPaintable.MORE_THAN_TWO_IN_LIST_AND
                        else
                            updateMyFontProperties.sepArray.[index].[index2] <- InputMappingHelpPaintable.SEP
                if not (JR.same(updateMyFontProperties.sepArray.[index].[index2], this.EMPTY_STRING)) then
                    updateMyFontProperties.sepWidthArray.[index].[index2] <- font.stringWidth(updateMyFontProperties.sepArray.[index].[index2])
                index2 <- index2 + 1
            index <- index + 1
        this.updateMyFontProperties <- updateMyFontProperties
        base.updateMeasurement(graphics)
    
    abstract update : selectedGameKey: GameKey * selectedInput: Input -> unit
    default this.update(selectedGameKey: GameKey, selectedInput: Input) : unit =
        let mutable stringMaker : StringMaker = (new StringMaker())
        this.logUtil.putF(stringMaker.append(CommonLabels.getInstance().START_LABEL).append("selected GameKey: ").append(this.stringUtil.toString(selectedGameKey)).append(" Input: ").append(this.stringUtil.toString(selectedInput)).ToString(), this, this.commonStrings.UPDATE)
        let mutable gameKeyMapping : PersistentInputMapping = PlatformInputMappingFactory.getInstance().getPersistentInputMappingInstance()
        let mutable size : int = this.gameInputMappingArray.Length
        let mutable keyInfo : string[] = (Array.zeroCreate<string> (size))
        let mutable keyMappingArray : BasicArrayList[] = (Array.zeroCreate<BasicArrayList> (size))
        let mutable actionBasicColor : BasicColor[] = (Array.zeroCreate<BasicColor> (size))
        let mutable inputBasicColorArray : BasicColor[][] = (Array.zeroCreate<BasicColor[]> (size))
        let mutable gameInputMapping : GameInputMapping = null
        let mutable gameKey : GameKey = null
        let mutable list_ : BasicArrayList = null
        let mutable index : int = 0
        while index < size do
            gameInputMapping <- this.gameInputMappingArray.[index]
            gameKey <- gameInputMapping.getGameKey()
            list_ <- gameKeyMapping.getInputMapping().getMappedInput(gameKey)
            let mutable size2 : int = list_.size()
            inputBasicColorArray.[index] <- (Array.zeroCreate<BasicColor> (size2))
            let mutable index2 : int = 0
            while index2 < size2 do
                inputBasicColorArray.[index].[index2] <- this.basicColor
                index2 <- index2 + 1
            if (JR.same(gameKey, selectedGameKey)) then
                ignore (stringMaker.delete(0, stringMaker.length()))
                this.logUtil.putF(stringMaker.append("Found: selected GameKey: ").append(this.stringUtil.toString(selectedGameKey)).ToString(), this, this.commonStrings.UPDATE)
                actionBasicColor.[index] <- this.selectedBasicColor
                let mutable indexOfSelectedInput : int = list_.indexOf(selectedInput)
                if indexOfSelectedInput >= 0 then
                    ignore (stringMaker.delete(0, stringMaker.length()))
                    this.logUtil.putF(stringMaker.append("Found: selected Input: ").append(this.stringUtil.toString(selectedInput)).ToString(), this, this.commonStrings.UPDATE)
                    inputBasicColorArray.[index].[indexOfSelectedInput] <- this.selectedBasicColor
            else
                actionBasicColor.[index] <- this.basicColor
            keyInfo.[index] <- gameInputMapping.getName()
            keyMappingArray.[index] <- list_
            index <- index + 1
        this.keyMappingArray <- keyMappingArray
        this.actionBasicColor <- actionBasicColor
        this.inputBasicColorArray <- inputBasicColorArray
        base.setInputInfoP(keyInfo)
        this.myFontProcessor <- this.updateMyFontProcessor
    
    member this.get(keyList: BasicArrayList) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable key : Input = null
        let mutable size : int = keyList.size()
        let mutable index : int = 0
        while index < size do
            key <- (box (keyList.objectArray.[index]) :?> Input)
            ignore (stringBuffer.append(key.getName()))
            if (index + 1) < keyList.size() then
                if keyList.size() = 2 then
                    ignore (stringBuffer.append(InputMappingHelpPaintable.AND))
                else
                    if (index + 2) = keyList.size() then
                        ignore (stringBuffer.append(InputMappingHelpPaintable.MORE_THAN_TWO_IN_LIST_AND))
                    else
                        ignore (stringBuffer.append(InputMappingHelpPaintable.SEP))
            index <- index + 1
        stringBuffer.ToString()
    
    override this.paint(graphics: Graphics) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable halfWidth : int = this.displayInfo.getLastHalfWidth()
        graphics.setColor(this.basicColor.intValue())
        graphics.drawString(this.title, (halfWidth - this.titleBeginWidth), this.updateMyFontProperties.charHeight, this.anchor)
        let mutable inputInfo : string[] = this.inputInfo
        let mutable size : int = inputInfo.Length
        let mutable y : int = 0
        let mutable deltaX : int = 0
        let mutable size2 : int = 0
        let mutable actionString : string = null
        let mutable input : Input = null
        let mutable list_ : BasicArrayList = null
        let mutable sep : string = null
        let mutable beginWidth : int = 0
        let mutable index : int = 0
        while index < size do
            y <- (index + 3) * this.updateMyFontProperties.charHeight
            deltaX <- 0
            list_ <- this.keyMappingArray.[index]
            size2 <- list_.size()
            beginWidth <- this.updateMyFontProperties.keymappingBeginWidthArray.[index]
            graphics.setColor(this.actionBasicColor.[index].intValue())
            actionString <- this.updateMyFontProperties.actionStringArray.[index]
            graphics.drawString(actionString, ((halfWidth - beginWidth) + deltaX), y, this.anchor)
            deltaX <- deltaX + this.updateMyFontProperties.actionStringDeltaXArray.[index]
            let mutable index2 : int = 0
            while index2 < size2 do
                input <- (box (list_.objectArray.[index2]) :?> Input)
                graphics.setColor(this.inputBasicColorArray.[index].[index2].intValue())
                graphics.drawString(input.getName(), ((halfWidth - beginWidth) + deltaX), y, this.anchor)
                deltaX <- deltaX + this.updateMyFontProperties.inputDeltaXArray.[index].[index2]
                sep <- this.updateMyFontProperties.sepArray.[index].[index2]
                graphics.setColor(this.basicColor.intValue())
                graphics.drawString(sep, ((halfWidth - beginWidth) + deltaX), y, this.anchor)
                deltaX <- deltaX + this.updateMyFontProperties.sepWidthArray.[index].[index2]
                index2 <- index2 + 1
            index <- index + 1


