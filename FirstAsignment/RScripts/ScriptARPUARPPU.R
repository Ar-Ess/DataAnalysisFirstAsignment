if (!require("ggplot2")) {
  install.packages("ggplot2")
  library(ggplot2)
}

data <-data.frame(Average =c("ARPU","ARPPU"), Revenue=c(as.numeric(ARPU$ARPU),as.numeric(ARPPU$ARPPU)))
ggplot(data,aes(x=Average,y=Revenue))+ geom_bar(stat = "identity")
