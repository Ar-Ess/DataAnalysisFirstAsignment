> D1 <- read.csv("~/GitHub/DataAnalysisFirstAsignment/FirstAsignment/ResultsCSV/D1.csv", header=FALSE)
Warning message:
'default.stringsAsFactors' is deprecated.
Use '`stringsAsFactors = FALSE`' instead.
See help("Deprecated") 
>   View(D1)
> view(D1)
Error in view(D1) : could not find function "view"
> plot.default(D1)
> slices <- c(D1[2, "V2"],1-D1[2,"V2"])
Error in 1 - D1[2, "V2"] : non-numeric argument to binary operator
> d1 <- D1[2,"V2"]
> slices <- c(d1,1-d1)
Error in 1 - d1 : non-numeric argument to binary operator
> slices <- c(d1,0.28)
> rest <- 1-d1
Error in 1 - d1 : non-numeric argument to binary operator
> rest <- 0,2784
Error: unexpected ',' in "rest <- 0,"
> rest <- 0.2784
> slices <- c(d1,rest)
> plot(slices)
> one <- 1
> rest <- one-d1
Error in one - d1 : non-numeric argument to binary operator
> lbls <- c("D1", "Rest")
> pie(slices, labels = lbls, main="D1 calculation")
Error in pie(slices, labels = lbls, main = "D1 calculation") : 
  'x' values must be positive.
> rest <- 1 - as.numeric(d1)
> d1 <- as.numeric(D1[2,"V2"])
> pie(slices, labels = lbls, main="D1 calculation")
Error in pie(slices, labels = lbls, main = "D1 calculation") : 
  'x' values must be positive.
> slices <- c(d1,rest)
> lbls <- c("D1", "Rest")
> pie(slices, labels = lbls, main="D1 calculation")
> slices <- c(d1,rest)
> lbls <- c("D1", "Rest")
> pct <- round(slices/sum(slices)*100)
> lbls <- paste(lbls,"%",sep="")
> pie(slices, labels = lbls, col=rainbow(length(lbls)),main="D1 calculation")
> pct <- round(slices/sum(slices)*100)
> lbls <- paste(lbls,pct)
> lbls <- paste(lbls,"%",sep="")
> pie(slices, labels = lbls, col=rainbow(length(lbls)),main="D1 calculation")
> library(plotrix)
Error in library(plotrix) : there is no package called ‘plotrix’
> lbls <- paste(lbls,sep="")
> pie(slices, labels = lbls, col=rainbow(length(lbls)),main="D1 calculation")
> save.image("~/GitHub/DataAnalysisFirstAsignment/FirstAsignment/ResultsCSV/D1Plot.RData")