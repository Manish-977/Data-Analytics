# This is naive approach, there are shortcut methods for doing it!
# Least square method
# Fitting y = ab^x to given n data points
import numpy as np

# Reading value of n
n = int(input("How many data points? "))

# Creating numpy array x & y to store n data points
x = np.zeros(n)
y = np.zeros(n)

# Reading data
print("Enter data:")
for i in range(n):
    x[i] = float(input("x["+str(i)+"]= "))
    y[i] = float(input("y["+str(i)+"]= "))
    
# Finding required sum for least square methods
sumX,sumX2,sumY,sumXY = 0,0,0,0
for i in range(n):
    sumX = sumX + x[i]
    sumX2 = sumX2 +x[i]*x[i]
    sumY = sumY + np.log(y[i])
    sumXY = sumXY + x[i]*np.log(y[i])

# Finding coefficients A and B
B = (n*sumXY-sumX*sumY)/(n*sumX2-sumX*sumX)
A = (sumY - B*sumX)/n

# Obtaining a and b
a = np.exp(A)
b = np.exp(B)

# Displaying coefficients a, b & equation
print("\nCoefficients are:")
print("a: ", a)
print("b: ", b)
