import numpy as np 
import pandas as pd 
import json
import mapFeature as mF

def sigmoid(X):
	return 1/(1+np.exp(-X))

def computeCost(X,y,theta,lamb):
	n = X.shape[0]
	return -1/(n)*np.asscalar(y.T@np.log(sigmoid(X@theta)) + (1-y).T@np.log(1-sigmoid(X@theta)))+((theta[1:,0]).T@(theta[1:,0])*lamb/(2*n))

def computeGradient(X,y,theta,lamb):
	n = X.shape[0]
	grad = 1/n*(X.T)@(sigmoid(X@theta)-y)
	grad[1:,0]+= lamb*(theta[1:,0])/n
	return grad

def gradientDescent(X,y,theta,lamb,alpha,num_iter):
	i = 0
	while i<= num_iter:
		i+=1
		theta = theta - alpha*computeGradient(X,y,theta,lamb)
	return theta

def predict(x,theta):
	return (sigmoid(x@theta)>=0.5).astype(int)
def precison(y,predict):
	return 1-(np.sum(np.abs(y-predict))/y.shape[0])
def main():
	config_path='./config.json'
	model_path='./model.json'
	names_path='./price.json'
	accuracy_path='./accuracy.json'

	config = pd.read_json(config_path,typ='series')

	data_path = config['Dataset']
	theta= np.array([config['Theta']]).T
	alpha = config['Alpha']
	lamb = 0
	num_iter = config['NumIter']

	
	with open(data_path,'rb') as csvfile:
		data = np.loadtxt(csvfile,delimiter=',')
		new_data = mF.mapFeature(data[:,0],data[:,1])
	length = len(new_data)
	X = np.array(new_data)
	y=  np.array(data[:,-1]).reshape((length,1))

	theta = gradientDescent(X,y,theta,lamb,alpha,num_iter)

	THETA = theta.T
	THETA = THETA.tolist()
	model={'Cost': computeCost(X,y,theta,lamb), 'Theta': THETA}
	MODEL = json.dumps(model)
	with open(model_path,'w') as fm:
		fm.write(MODEL)

	accuracy= {'Accuracy': precison(y,predict(X,theta))}
	ACCURACY = json.dumps(accuracy)
	with open(accuracy_path,'w') as fa:
		fa.write(ACCURACY)

	fa.close()
	fm.close()

if __name__ == '__main__':
	main()