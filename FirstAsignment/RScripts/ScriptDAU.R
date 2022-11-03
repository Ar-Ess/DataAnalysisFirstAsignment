if (!require("ggplot2")) {
  install.packages("ggplot2")
  library(ggplot2)
}
xValue <- DAU$DAY
yValue <- as.numeric(DAU$DAU)
data <- data.frame(xValue,yValue)
ggplot(data,aes(x=xValue,y=yValue))
ggplot(data,aes(x=xValue,y=yValue)) + geom_line()
ggplot(data,aes(x=xValue,y=yValue, group=1)) + geom_line()
