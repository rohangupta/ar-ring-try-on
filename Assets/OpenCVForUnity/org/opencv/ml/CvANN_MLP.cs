
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{


// C++: class CvANN_MLP
/**
 * <p>MLP model.</p>
 *
 * <p>Unlike many other models in ML that are constructed and trained at once, in
 * the MLP model these steps are separated. First, a network with the specified
 * topology is created using the non-default constructor or the method
 * "CvANN_MLP.create". All the weights are set to zeros. Then, the network is
 * trained using a set of input and output vectors. The training procedure can
 * be repeated more than once, that is, the weights can be adjusted based on the
 * new training data.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp">org.opencv.ml.CvANN_MLP : public CvStatModel</a>
 */
		public class CvANN_MLP : CvStatModel
		{


				protected override void Dispose (bool disposing)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			
						try {

								if (disposing) {
								}

								if (IsEnabledDispose) {
										if (nativeObj != IntPtr.Zero)
												ml_CvANN_1MLP_delete (nativeObj);
										nativeObj = IntPtr.Zero;
								}
				
						} finally {
								base.Dispose (disposing);
						}
			
						#else
						return;
						#endif
				}
	
				protected CvANN_MLP (IntPtr addr): base(addr)
				{
				}
	
				public const int IDENTITY = 0;
				public const int SIGMOID_SYM = 1;
				public const int GAUSSIAN = 2;
				public const int UPDATE_WEIGHTS = 1;
				public const int NO_INPUT_SCALE = 2;
				public const int NO_OUTPUT_SCALE = 4;
	
	
				//
				// C++:   CvANN_MLP::CvANN_MLP()
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The advanced constructor allows to create MLP with the specified topology.
 * See "CvANN_MLP.create" for details.</p>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-cvann-mlp">org.opencv.ml.CvANN_MLP.CvANN_MLP</a>
 */

				public   CvANN_MLP ():
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			  base( ml_CvANN_1MLP_CvANN_1MLP_10() )
#else
base(IntPtr.Zero)
#endif
				{

						return;


				}

	
	
				//
				// C++:   CvANN_MLP::CvANN_MLP(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
				//
	
				/**
 * <p>The constructors.</p>
 *
 * <p>The advanced constructor allows to create MLP with the specified topology.
 * See "CvANN_MLP.create" for details.</p>
 *
 * @param layerSizes a layerSizes
 * @param activateFunc a activateFunc
 * @param fparam1 a fparam1
 * @param fparam2 a fparam2
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-cvann-mlp">org.opencv.ml.CvANN_MLP.CvANN_MLP</a>
 */


				public   CvANN_MLP (Mat layerSizes, int activateFunc, double fparam1, double fparam2) :
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			base( ml_CvANN_1MLP_CvANN_1MLP_11(layerSizes.nativeObj, activateFunc, fparam1, fparam2) )
#else
			base( IntPtr.Zero )
#endif
				{
		


						return;

				}

				/**
 * <p>The constructors.</p>
 *
 * <p>The advanced constructor allows to create MLP with the specified topology.
 * See "CvANN_MLP.create" for details.</p>
 *
 * @param layerSizes a layerSizes
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-cvann-mlp">org.opencv.ml.CvANN_MLP.CvANN_MLP</a>
 */

				public   CvANN_MLP (Mat layerSizes) : 
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
			base( ml_CvANN_1MLP_CvANN_1MLP_12(layerSizes.nativeObj) )
#else
			base( IntPtr.Zero )
			
#endif
				{
		

		
						return;
				}

	
	
				//
				// C++:  void CvANN_MLP::clear()
				//
	
				public  void clear ()
				{
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_clear_10 (nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  void CvANN_MLP::create(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
				//
	
				/**
 * <p>Constructs MLP with the specified topology.</p>
 *
 * <p>The method creates an MLP network with the specified topology and assigns the
 * same activation function to all the neurons.</p>
 *
 * @param layerSizes Integer vector specifying the number of neurons in each
 * layer including the input and output layers.
 * @param activateFunc Parameter specifying the activation function for each
 * neuron: one of <code>CvANN_MLP.IDENTITY</code>, <code>CvANN_MLP.SIGMOID_SYM</code>,
 * and <code>CvANN_MLP.GAUSSIAN</code>.
 * @param fparam1 Free parameter of the activation function, <em>alpha</em>. See
 * the formulas in the introduction section.
 * @param fparam2 Free parameter of the activation function, <em>beta</em>. See
 * the formulas in the introduction section.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-create">org.opencv.ml.CvANN_MLP.create</a>
 */
				public  void create (Mat layerSizes, int activateFunc, double fparam1, double fparam2)
				{
						if (layerSizes != null)
								layerSizes.ThrowIfDisposed ();
						ThrowIfDisposed ();


						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_create_10 (nativeObj, layerSizes.nativeObj, activateFunc, fparam1, fparam2);
		
						return;
						#else
						return;
						#endif
				}
	
				/**
 * <p>Constructs MLP with the specified topology.</p>
 *
 * <p>The method creates an MLP network with the specified topology and assigns the
 * same activation function to all the neurons.</p>
 *
 * @param layerSizes Integer vector specifying the number of neurons in each
 * layer including the input and output layers.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-create">org.opencv.ml.CvANN_MLP.create</a>
 */
				public  void create (Mat layerSizes)
				{
						if (layerSizes != null)
								layerSizes.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						ml_CvANN_1MLP_create_11 (nativeObj, layerSizes.nativeObj);
		
						return;
						#else
						return;
						#endif
				}
	
	
				//
				// C++:  float CvANN_MLP::predict(Mat inputs, Mat& outputs)
				//
	
				/**
 * <p>Predicts responses for input samples.</p>
 *
 * <p>The method returns a dummy value which should be ignored.</p>
 *
 * <p>If you are using the default <code>cvANN_MLP.SIGMOID_SYM</code> activation
 * function with the default parameter values fparam1=0 and fparam2=0 then the
 * function used is y = 1.7159*tanh(2/3 * x), so the output will range from
 * [-1.7159, 1.7159], instead of [0,1].</p>
 *
 * @param inputs Input samples.
 * @param outputs Predicted responses for corresponding samples.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-predict">org.opencv.ml.CvANN_MLP.predict</a>
 */
				public  float predict (Mat inputs, Mat outputs)
				{
						if (inputs != null)
								inputs.ThrowIfDisposed ();
						if (outputs != null)
								outputs.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						float retVal = ml_CvANN_1MLP_predict_10 (nativeObj, inputs.nativeObj, outputs.nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
				//
				// C++:  int CvANN_MLP::train(Mat inputs, Mat outputs, Mat sampleWeights, Mat sampleIdx = cv::Mat(), CvANN_MLP_TrainParams params = CvANN_MLP_TrainParams(), int flags = 0)
				//
	
				/**
 * <p>Trains/updates MLP.</p>
 *
 * <p>This method applies the specified training algorithm to computing/adjusting
 * the network weights. It returns the number of done iterations.</p>
 *
 * <p>The RPROP training algorithm is parallelized with the TBB library.</p>
 *
 * <p>If you are using the default <code>cvANN_MLP.SIGMOID_SYM</code> activation
 * function then the output should be in the range [-1,1], instead of [0,1], for
 * optimal results.</p>
 *
 * @param inputs Floating-point matrix of input vectors, one vector per row.
 * @param outputs Floating-point matrix of the corresponding output vectors, one
 * vector per row.
 * @param sampleWeights (RPROP only) Optional floating-point vector of weights
 * for each sample. Some samples may be more important than others for training.
 * You may want to raise the weight of certain classes to find the right balance
 * between hit-rate and false-alarm rate, and so on.
 * @param sampleIdx Optional integer vector indicating the samples (rows of
 * <code>inputs</code> and <code>outputs</code>) that are taken into account.
 * @param params Training parameters. See the "CvANN_MLP_TrainParams"
 * description.
 * @param flags Various parameters to control the training algorithm. A
 * combination of the following parameters is possible:
 * <ul>
 *   <li> UPDATE_WEIGHTS Algorithm updates the network weights, rather than
 * computes them from scratch. In the latter case the weights are initialized
 * using the Nguyen-Widrow algorithm.
 *   <li> NO_INPUT_SCALE Algorithm does not normalize the input vectors. If this
 * flag is not set, the training algorithm normalizes each input feature
 * independently, shifting its mean value to 0 and making the standard deviation
 * equal to 1. If the network is assumed to be updated frequently, the new
 * training data could be much different from original one. In this case, you
 * should take care of proper normalization.
 *   <li> NO_OUTPUT_SCALE Algorithm does not normalize the output vectors. If
 * the flag is not set, the training algorithm normalizes each output feature
 * independently, by transforming it to the certain range depending on the used
 * activation function.
 * </ul>
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-train">org.opencv.ml.CvANN_MLP.train</a>
 */
				public  int train (Mat inputs, Mat outputs, Mat sampleWeights, Mat sampleIdx, CvANN_MLP_TrainParams _params, int flags)
				{
						if (inputs != null)
								inputs.ThrowIfDisposed ();
						if (outputs != null)
								outputs.ThrowIfDisposed ();
						if (sampleWeights != null)
								sampleWeights.ThrowIfDisposed ();
						if (sampleIdx != null)
								sampleIdx.ThrowIfDisposed ();
						if (_params != null)
								_params.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvANN_1MLP_train_10 (nativeObj, inputs.nativeObj, outputs.nativeObj, sampleWeights.nativeObj, sampleIdx.nativeObj, _params.nativeObj, flags);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
				/**
 * <p>Trains/updates MLP.</p>
 *
 * <p>This method applies the specified training algorithm to computing/adjusting
 * the network weights. It returns the number of done iterations.</p>
 *
 * <p>The RPROP training algorithm is parallelized with the TBB library.</p>
 *
 * <p>If you are using the default <code>cvANN_MLP.SIGMOID_SYM</code> activation
 * function then the output should be in the range [-1,1], instead of [0,1], for
 * optimal results.</p>
 *
 * @param inputs Floating-point matrix of input vectors, one vector per row.
 * @param outputs Floating-point matrix of the corresponding output vectors, one
 * vector per row.
 * @param sampleWeights (RPROP only) Optional floating-point vector of weights
 * for each sample. Some samples may be more important than others for training.
 * You may want to raise the weight of certain classes to find the right balance
 * between hit-rate and false-alarm rate, and so on.
 *
 * @see <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-train">org.opencv.ml.CvANN_MLP.train</a>
 */
				public  int train (Mat inputs, Mat outputs, Mat sampleWeights)
				{
						if (inputs != null)
								inputs.ThrowIfDisposed ();
						if (outputs != null)
								outputs.ThrowIfDisposed ();
						if (sampleWeights != null)
								sampleWeights.ThrowIfDisposed ();
						ThrowIfDisposed ();

						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || !(UNITY_4_5 || UNITY_4_6)
						int retVal = ml_CvANN_1MLP_train_11 (nativeObj, inputs.nativeObj, outputs.nativeObj, sampleWeights.nativeObj);
		
						return retVal;
						#else
						return 0;
						#endif
				}
	
	
//	@Override
//	protected void finalize() throws Throwable {
//			ml_CvANN_1MLP_delete(nativeObj);
//	}
	
	
	

		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CvANN_MLP::CvANN_MLP()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvANN_1MLP_CvANN_1MLP_10();
		
		// C++:   CvANN_MLP::CvANN_MLP(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvANN_1MLP_CvANN_1MLP_11(IntPtr layerSizes_nativeObj, int activateFunc, double fparam1, double fparam2);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr ml_CvANN_1MLP_CvANN_1MLP_12(IntPtr layerSizes_nativeObj);
		
		// C++:  void CvANN_MLP::clear()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_clear_10(IntPtr nativeObj);
		
		// C++:  void CvANN_MLP::create(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_create_10(IntPtr nativeObj, IntPtr layerSizes_nativeObj, int activateFunc, double fparam1, double fparam2);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_create_11(IntPtr nativeObj, IntPtr layerSizes_nativeObj);
		
		// C++:  float CvANN_MLP::predict(Mat inputs, Mat& outputs)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern float ml_CvANN_1MLP_predict_10(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj);
		
		// C++:  int CvANN_MLP::train(Mat inputs, Mat outputs, Mat sampleWeights, Mat sampleIdx = cv::Mat(), CvANN_MLP_TrainParams params = CvANN_MLP_TrainParams(), int flags = 0)
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvANN_1MLP_train_10(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr sampleWeights_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj, int flags);
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern int ml_CvANN_1MLP_train_11(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr sampleWeights_nativeObj);
		
		// native support for java finalize()
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		private static extern void ml_CvANN_1MLP_delete(IntPtr nativeObj);

#else
		
				// C++:   CvANN_MLP::CvANN_MLP()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvANN_1MLP_CvANN_1MLP_10 ();
		
				// C++:   CvANN_MLP::CvANN_MLP(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvANN_1MLP_CvANN_1MLP_11 (IntPtr layerSizes_nativeObj, int activateFunc, double fparam1, double fparam2);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern IntPtr ml_CvANN_1MLP_CvANN_1MLP_12 (IntPtr layerSizes_nativeObj);
		
				// C++:  void CvANN_MLP::clear()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_clear_10 (IntPtr nativeObj);
		
				// C++:  void CvANN_MLP::create(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_create_10 (IntPtr nativeObj, IntPtr layerSizes_nativeObj, int activateFunc, double fparam1, double fparam2);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_create_11 (IntPtr nativeObj, IntPtr layerSizes_nativeObj);
		
				// C++:  float CvANN_MLP::predict(Mat inputs, Mat& outputs)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern float ml_CvANN_1MLP_predict_10 (IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj);
		
				// C++:  int CvANN_MLP::train(Mat inputs, Mat outputs, Mat sampleWeights, Mat sampleIdx = cv::Mat(), CvANN_MLP_TrainParams params = CvANN_MLP_TrainParams(), int flags = 0)
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvANN_1MLP_train_10 (IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr sampleWeights_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj, int flags);

				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern int ml_CvANN_1MLP_train_11 (IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr sampleWeights_nativeObj);
		
				// native support for java finalize()
				[DllImport("opencvforunity", CallingConvention = CallingConvention.Cdecl)]
				private static extern void ml_CvANN_1MLP_delete (IntPtr nativeObj);
		#endif
		}
}
