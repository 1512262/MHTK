import numpy as np 
import pandas as pd 
import json

def readData(data_path):
	df = pd.read_csv(data_path,sep=',',header=None)
	if df is None:
		print('Wrong Path!!!')
	return df

def mu(X):
	return np.mean(X,axis=0)
def sigma(X):
	return np.std(X,axis=0)
def normalizeFeature(X):
	return ((X-mu(X))/sigma(X))

def computeCost(X,y,theta):
	n = X.shape[0]
	return 1/(2*n)*np.asscalar((X@theta-y).T@(X@theta-y))

def computeGradient(X,y,theta):
	n = X.shape[0]
	return 1/n*(X.T)@(X@theta-y)

def gradientDescent(X,y,theta,alpha,num_iter):
	i = 0
	while i<= num_iter:
		i+=1
		theta = theta - alpha*computeGradient(X,y,theta)
	return theta

def predict(x,theta):
	return x@theta

def main():
	config_path='./config.json'
	model_path='./model.json'
	test_path='./price.json'

	config = pd.read_json(config_path,typ='series')

	data_path = config['Dataset']
	theta= np.array([config['Theta']]).T
	alpha = config['Alpha']
	num_iter = config['NumIter']
	
	df = readData(data_path)
	
	length = len(df)
	ones = np.ones((length))

	X = np.c_[ones,normalizeFeature(np.array(df.iloc[:,:-1].values))]
	y=  np.array(df.iloc[:,-1].values).reshape((length,1))

	theta = gradientDescent(X,y,theta,alpha,num_iter)

	THETA = theta.T
	THETA = THETA.tolist()
	model={'Cost': computeCost(X,y,theta), 'Theta': THETA}
	MODEL = json.dumps(model)
	with open(model_path,'w') as fm:
		fm.write(MODEL)

		### Predict value ###
	test = pd.read_json(test_path,typ='series')

	muy = mu(np.array(df.iloc[:,:-1].values))
	sig = sigma(np.array(df.iloc[:,:-1].values))

	x = np.c_[1,((np.array([[test['Size'],test['Bedroom']]]) - muy)/sig)]
	result ={'Size': test['Size'],
			'Bedroom':test['Bedroom'], 
			'Price': predict(x,theta).tolist()}
	RESULT = json.dumps(result)
	with open(test_path,'w') as fr:
		fr.write(RESULT)

	fr.close()
	fm.close()
if __name__ == '__main__':
	main()